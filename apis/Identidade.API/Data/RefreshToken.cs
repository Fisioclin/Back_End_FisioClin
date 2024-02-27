namespace Identidade.API.Data
{
    public class RefreshToken
    {
        /// <summary>
        /// Nome de usuario
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Token de atualização
        /// </summary>
        public string TokenString { get; set; }
        /// <summary>
        /// Data de expiração
        /// </summary>
        public DateTime ExpireAt { get; set; }
    }
}
