
using AutoMapper;
using Core.Util.Application;
using Core.Util.Auth;
using Core.Util.Domain;
using Core.Util.Mediator;
using Core.Util.Retorno;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Core.Util.Controllers
{
    [ApiController]
    //[Authorize]
    public class ControllerGeral<Entity, AddCommand, UpdCommand, EntityDTO> : ControllerBase
        where Entity : BaseModel
        where AddCommand : CommandAdd
        where UpdCommand : CommandUpd
        where EntityDTO : BaseDTO
    {
        protected readonly IBaseRepository<Entity> _baseRepositorie;
        protected ICollection<string> Erros = new List<string>();
        private readonly IMapper _mapper;
        private readonly AuthenticatedUser _authenticatedUser;
        protected int status = 1;
        private readonly IMediatorHandler _mediator;

        public ControllerGeral(
            IBaseRepository<Entity> baseRepositorie,
            IMapper mapper,
            IMediatorHandler mediator,
            AuthenticatedUser authenticatedUser)
        {
            _baseRepositorie = baseRepositorie;
            _mapper = mapper;
            _authenticatedUser = authenticatedUser;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var companyId = _authenticatedUser.ObterCompanyId();

            return CustomResponse(await _baseRepositorie.GetAsync(companyId));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var companyId = _authenticatedUser.ObterCompanyId();

            var obj = await _baseRepositorie.GetAsync(id,companyId);

            if (obj is null)
            {
                return NotFound();
            }

            return CustomResponse(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddCommand newServico)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                newServico.CompanyId = _authenticatedUser.ObterCompanyId();
                newServico.UsuarioId = _authenticatedUser.ObterId();
                var result = await _mediator.EnviarComandoAdd(newServico);
                if (result.IsValid)
                {
                    return CustomResponse();
                }
                else
                {
                    return CustomResponse(result);
                }
            }
            catch (Exception ex)
            {
                AdicionarErroProcessamento(ex.Message);
                return CustomResponse();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdCommand updatedServico)
        {
            var companyId = _authenticatedUser.ObterCompanyId();
            var userId = _authenticatedUser.ObterId();

            var obj = await _baseRepositorie.GetAsync(id, companyId);

            if (obj is null)
            {
                return NotFound();
            }

            if (obj.CompanyId != companyId)
            {
                return NotFound();
            }

            updatedServico.UsuarioId = userId;

            try
            {
                if (!ModelState.IsValid) return BadRequest("");

                updatedServico.CompanyId = _authenticatedUser.ObterCompanyId(); ;
                var result = await _mediator.EnviarComandoUpd(updatedServico);
                if (result.IsValid)
                {
                    return CustomResponse();
                }
                else
                {
                    return CustomResponse(result);
                }
            }
            catch (Exception ex)
            {
                AdicionarErroProcessamento(ex.Message);
                return CustomResponse();
            }
        }

        

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var companyId = _authenticatedUser.ObterCompanyId();

            var obj = await _baseRepositorie.GetAsync(id,companyId);

            if (obj is null)
            {
                return NotFound();
            }

            if (obj.CompanyId != companyId)
            {
                return NotFound();
            }
            _baseRepositorie.RemoveAsync(id);

            return NoContent();
        }

        protected void AdicionarErroProcessamento(string erro)
        {
            Erros.Add(erro);
        }

        protected void AdicionarStatusProcessamento(int status)
        {
            this.status = status;
        }

        protected void LimparErrosProcessamento()
        {
            Erros.Clear();
        }

        protected bool OperacaoValida()
        {
            return !Erros.Any();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }
            return BadRequest(
                new Retorno("Mensagens", Erros.ToArray(), status));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                AdicionarErroProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }

        protected ActionResult CustomResponse(ResponseResult resposta)
        {
            ResponsePossuiErros(resposta);

            return CustomResponse();
        }

        protected bool ResponsePossuiErros(ResponseResult resposta)
        {
            if (resposta == null || !resposta.Errors.Mensagens.Any()) return false;

            foreach (var mensagem in resposta.Errors.Mensagens)
            {
                AdicionarErroProcessamento(mensagem);
            }

            return true;
        }
    }
}
