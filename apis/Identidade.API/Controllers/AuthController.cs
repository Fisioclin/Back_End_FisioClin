
using Core.Util.AspNetUser.Interface;
using Core.Util.Controllers;
using Core.Util.Email.Interface;
using Identidade.API.Configuration;
using Identidade.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Posto.Identidade.API.Extensions;
using Posto.Identidade.API.Models;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Posto.Identidade.API.Controllers
{
    [ApiController]
    [Route("Api/identidade")]
    public class AuthController : ControllerIdentity
    {
        private readonly SignInManager<UsuarioRegistroModel> _signInManager;
        private readonly UserManager<UsuarioRegistroModel> _userManager;
        private readonly RoleManager<RoleModel> _roleManager;
        private readonly AppSettings _appSettings;
        private readonly JwtService _jwtService;
        private readonly IEmailHelper _emailHelper;
        private readonly IAspNetUser _aspNetUser;


        public AuthController(SignInManager<UsuarioRegistroModel> signInManager,
                                UserManager<UsuarioRegistroModel> userManager,
                                RoleManager<RoleModel> roleManager,
                                IOptions<AppSettings> appSettings,
                                JwtService jwtService,
                                IEmailHelper emailHelper,
                                IAspNetUser aspNetUser)

        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _appSettings = appSettings.Value;
            _emailHelper = emailHelper;
            _aspNetUser = aspNetUser;
            _jwtService = jwtService;
        }
        [HttpPost("create-role")]
        //[Authorize(Roles = "EMPRESA")]
        public async Task<IActionResult> CreateRole([Required] string name)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            var empresaId = _aspNetUser.ObterEmpresaId();
            if (!string.IsNullOrWhiteSpace(name))
            {
                var role = new RoleModel
                {
                    Name = name,
                    EmpresaId = empresaId
                };

                var result = await _roleManager.CreateAsync(role);

                if (!result.Succeeded)
                {
                    string errorResult = "";
                    foreach (IdentityError error in result.Errors)
                    {
                        errorResult += error.Description;

                    }
                    AdicionarErroProcessamento(errorResult);
                    AdicionarStatusProcessamento((int)EnumStatus.ERRO_CRIACAO_ROLE);
                    return CustomResponse();
                }
            }
            return CustomResponse();
        }
        [HttpPost("novo-user")]
        [Authorize(Roles = "EMPRESA")]
        public async Task<ActionResult> RegistrarUser(UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            var empresaId = _aspNetUser.ObterEmpresaId();

            var user = new UsuarioRegistroModel
            {
                UserName = usuarioRegistro.Email,
                NormalizedUserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                Nome = usuarioRegistro.Nome,
                NormalizedEmail = usuarioRegistro.Email,
                EmailConfirmed = true,
                PhoneNumber = "",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                ContaConfirmada = false,
                DataCodigoConfirmacao = DateTime.Now.AddHours(1),
                CodigoConfirmacao = GerarCodigoDeConfirmacao(),
                EmpresaId = empresaId
            };

            var account = await _userManager.FindByIdAsync(user.EmpresaId.ToString());

            if (account == null)
            {
                AdicionarErroProcessamento("Empresa não cadastrada, favor conferir o código enviado.");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_EMPRESA_NAO_CADASTRADA);
                return CustomResponse();
            }

            if (!account.ContaConfirmada)
            {
                AdicionarErroProcessamento("Empresa cadastrada, mas ainda não teve a conta confirmada favor conferir com seu superior.");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_EMPRESA_NAO_CONFIRMADA);
                return CustomResponse();
            }

            var result = await _userManager.CreateAsync(user, usuarioRegistro.Senha);

            if (result.Succeeded)
            {
                var roles = new RoleModel
                {
                    Name = usuarioRegistro.Tipo,
                };

                var role = await _roleManager.GetRoleNameAsync(roles);

                if (role == null)
                {
                    AdicionarErroProcessamento("Não existe esse tipo.");
                    AdicionarStatusProcessamento((int)EnumStatus.ERRO_TIPO_USUARIO_NAO_EXISTE);
                    return CustomResponse();
                }
                await _userManager.AddToRoleAsync(user, usuarioRegistro.Tipo);

                string message = $"Sua código é :{user.CodigoConfirmacao}";
                string subject = "[CÓDIGO DE CONFIRMAÇÃO HealthFisio]";

                await this._emailHelper.SendEmail(user.Email, message, subject);

                return CustomResponse();
            }
            if (result.Errors?.Count() > 0)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERROS_IDENTITY);
                foreach (var erro in result.Errors)
                {
                    AdicionarErroProcessamento(erro.Description);
                }
            }

            return CustomResponse();
        }
        [HttpPost("nova-conta")]
        public async Task<ActionResult> RegistrarConta(ContaRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            var user = new UsuarioRegistroModel
            {
                UserName = usuarioRegistro.Email,
                NormalizedUserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                Nome = usuarioRegistro.Nome,
                NormalizedEmail = usuarioRegistro.Email,
                EmailConfirmed = true,
                PhoneNumber = "",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                ContaConfirmada = false,
                DataCodigoConfirmacao = DateTime.Now.AddHours(1),
                CodigoConfirmacao = GerarCodigoDeConfirmacao(),
                EmpresaId = Guid.Empty
            };

            var result = await _userManager.CreateAsync(user, usuarioRegistro.Senha);

            if (result.Succeeded)
            {
                var roles = new RoleModel
                {
                    Name = "EMPRESA"
                };
                var role = await _roleManager.GetRoleNameAsync(roles);

                await _userManager.AddToRoleAsync(user, role);

                string message = $"Sua código é :{user.CodigoConfirmacao}";
                string subject = "[CÓDIGO DE CONFIRMAÇÃO HealthFisio]";

                await this._emailHelper.SendEmail(user.Email, message, subject);

                return CustomResponse(result);
            }

            if (result.Errors?.Count() > 0)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERROS_IDENTITY);
                foreach (var erro in result.Errors)
                {
                    AdicionarErroProcessamento(erro.Description);
                }
            }

            return CustomResponse();
        }
        [HttpPost("autenticar")]
        public async Task<ActionResult> Login(UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            var appUser = await _userManager.FindByEmailAsync(usuarioLogin.Email);
            if (appUser == null)
            {
                AdicionarErroProcessamento("Usuario ou senha incorretos");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_SENHA_INCORRETOS);
                return CustomResponse();
            }
            if (appUser.ContaConfirmada)
            {
                var result = await _signInManager.PasswordSignInAsync(usuarioLogin.Email, usuarioLogin.Senha, false, true);

                if (result.Succeeded)
                {
                    var userLoged = new LoginResult()
                    {
                        UserName = appUser.UserName,
                        UrlImagemPerfil = "",
                        CompanyId = appUser.EmpresaId == Guid.Empty ? new Guid(appUser.Id) : appUser.EmpresaId,
                        Id = appUser.Id
                    };

                    var claims = await _userManager.GetClaimsAsync(appUser);

                    var roles = (await _userManager.GetRolesAsync(appUser)).ToList();

                    var jwtResult = this._jwtService.GenerateTokens(appUser.UserName, roles, (appUser.EmpresaId != Guid.Empty ? appUser.EmpresaId.ToString() : appUser.Id), appUser.Id.ToString(), claims, DateTime.Now);

                    userLoged.AccessToken = jwtResult.AccessToken;
                    userLoged.RefreshToken = jwtResult.RefreshToken.TokenString;

                    return CustomResponse(userLoged);
                }

                if (result.IsLockedOut)
                {
                    AdicionarErroProcessamento("Usuario temporariamente bloqueado por tentativas invalidas");
                    AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_BLOQUEADO);
                    return CustomResponse();
                }

                AdicionarErroProcessamento("Usuario ou senha incorretos");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_SENHA_INCORRETOS);
                return CustomResponse();
            }
            else
            {
                AdicionarErroProcessamento("Usuario ainda não teve a conta confirmada.");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_NAO_CONFIRMADO);
                return CustomResponse();
            }
        }
        [HttpPut("confirmacao-conta")]
        public async Task<IActionResult> ConfirmConta(ConfirmarContaModel confirmarConta)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }

            var user = await _userManager.FindByEmailAsync(confirmarConta.Email);
            if (user == null)
            {
                AdicionarErroProcessamento("Erro, usuario não encontrado");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_NAO_ENCONTRADO);
                return CustomResponse();
            }

            var result = user.CodigoConfirmacao == confirmarConta.CodigoConfirmacao;

            if (result)
            {
                user.ContaConfirmada = true;
                await _userManager.UpdateAsync(user);
                return CustomResponse();
            }
            else
            {
                AdicionarErroProcessamento("Código de confirmação diferente");
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_CODIGO_ERRADO);
                return CustomResponse();
            }
        }
        [HttpPost("reenviar-codigo-confirmacao")]
        public async Task<IActionResult> ReenviarCodigoConfirmacao(UsuarioReenviarCodigo usuarioReenviarCodigo)
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            if (ModelState.IsValid)
            {
                var userOld = await _userManager.FindByEmailAsync(usuarioReenviarCodigo.Email);
                if (userOld == null)
                {
                    AdicionarErroProcessamento("Erro, usuario não encontrado");
                    AdicionarStatusProcessamento((int)EnumStatus.ERRO_USUARIO_NAO_ENCONTRADO);
                    return CustomResponse();
                }

                userOld.DataCodigoConfirmacao = DateTime.Now.AddHours(1);
                userOld.CodigoConfirmacao = GerarCodigoDeConfirmacao();

                IdentityResult retornoUpdate = await _userManager.UpdateAsync(userOld);

                if (retornoUpdate.Succeeded)
                {
                    string message = $"Sua código novo é :{userOld.CodigoConfirmacao}";
                    string subject = "[CÓDIGO DE CONFIRMAÇÃO HealthFisio]";

                    await this._emailHelper.SendEmail(userOld.Email, message, subject);

                    return CustomResponse();
                }
                else
                {
                    if (retornoUpdate.Errors?.Count() > 0)
                    {
                        AdicionarStatusProcessamento((int)EnumStatus.ERROS_IDENTITY);
                        foreach (var erro in retornoUpdate.Errors)
                        {
                            AdicionarErroProcessamento(erro.Description);
                        }
                    }
                    return CustomResponse();
                }
            }
            return CustomResponse();
        }
        [HttpGet("get-role")]
        [Authorize(Roles = "EMPRESA")]
        public async Task<IActionResult> GetRoles()
        {
            if (!ModelState.IsValid)
            {
                AdicionarStatusProcessamento((int)EnumStatus.ERRO_MODEL_STATE);
                return CustomResponse(ModelState);
            }
            var empresaId = _aspNetUser.ObterEmpresaId();

            var roles = _roleManager.Roles.ToList().Where(c => c.EmpresaId == empresaId && c.Name != "EMPRESA");
            return CustomResponse(roles);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<UsuarioRespostaLogin> GerarToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            var claims = await _userManager.GetClaimsAsync(user);

            //var userRoles = await _userManager.GetRolesAsync(user);

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Nbf, ToUnixEpochDate(DateTime.UtcNow).ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(DateTime.UtcNow).ToString(), ClaimValueTypes.Integer64));

            //foreach (var userRole in userRoles)
            //{
            //    claims.Add(new Claim("role", userRole));
            //}

            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var token = tokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _appSettings.Emissor,
                Audience = _appSettings.ValidoEm,
                Subject = identityClaims,
                Expires = DateTime.UtcNow.AddHours(_appSettings.ExpiracaoHoras),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            });

            var encodedToken = tokenHandler.WriteToken(token);

            var response = new UsuarioRespostaLogin
            {
                AccessToken = encodedToken,
                ExpiresIn = TimeSpan.FromHours(_appSettings.ExpiracaoHoras).TotalSeconds,
                UsuarioToken = new UsuarioToken
                {
                    Id = user.Id,
                    Email = user.Email,
                    Claims = claims.Select(c => new UsuarioClaim { Type = c.Type, Value = c.Value })
                }
            };

            return response;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
        string GerarCodigoDeConfirmacao()
        {
            // Inicialize o gerador de números aleatórios com uma semente única
            Random random = new Random(Guid.NewGuid().GetHashCode());

            var numeros = new List<int>();
            // Gere um número inteiro de 6 dígitos
            int numero = random.Next(1, 9);
            numeros.Add(numero);

            for (int i = 0; i < 5; i++)
            {
                numero = random.Next(1, 9);
                while (numeros.Contains(numero))
                {
                    numero = random.Next(1, 9);
                }
                numeros.Add(numero);
            }

            return string.Join("", numeros); ;
        }
    }
}
