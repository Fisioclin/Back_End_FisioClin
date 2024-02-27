namespace Core.Util.Application
{
    public class BaseDTO
    {
        public int IdNumerico { get; set; }
        public Guid Id { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public Guid UsuarioCriacaoId { get; set; }
        public Guid UsuarioAtualizacaoId { get; set; }
        public int Status { get; set; }
    }
}
