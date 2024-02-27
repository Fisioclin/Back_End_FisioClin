using System.ComponentModel.DataAnnotations;

namespace Identidade.API.Data
{
    public class LoginResult
    {
        /// <summary>
        /// Identificador de login
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Nome de usuario
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Token de acesso
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Token de atualização
        /// </summary>
        public string RefreshToken { get; set; }
        /// <summary>
        /// URL da imagem de perfil
        /// </summary>
        public string UrlImagemPerfil{ get; set; }
        /// <summary>
        /// Código da empresa
        /// </summary>
        public Guid CompanyId{ get; set; }
    }

    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
