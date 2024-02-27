using Posto.Core.Messages;

namespace Core.Util.Domain
{
    public class BaseModel
    {
        public BaseModel()
        {
        }

        public BaseModel(int id, DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, Guid companyId, int status)
        {
            Id = id;
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            CompanyId = companyId;
            Status = status;
        }

        public int Id { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public Guid UsuarioCriacaoId { get; set; }
        public Guid UsuarioAtualizacaoId { get; set; }
        public Guid CompanyId { get; set; }
        public int Status { get; set; }

        private List<Event> _notificacoes;
        public IReadOnlyCollection<Event> Notificacoes => _notificacoes?.AsReadOnly();

        public void AdicionarEvento(Event evento)
        {
            _notificacoes = _notificacoes ?? new List<Event>();
            _notificacoes.Add(evento);
        }

        public void RemoverEvento(Event eventItem)
        {
            _notificacoes?.Remove(eventItem);
        }

        public void LimparEventos()
        {
            _notificacoes?.Clear();
        }
    }
}
