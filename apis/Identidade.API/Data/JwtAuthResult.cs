namespace Identidade.API.Data
{
    public class JwtAuthResult
    {
        /// <summary>
        /// Token de acesso
        /// </summary>
        public string AccessToken { get; set; }
        /// <summary>
        /// Token de atualização
        /// </summary>
        public RefreshToken RefreshToken { get; set; }
    }
}
