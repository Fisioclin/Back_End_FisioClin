using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;

namespace FichaAvaliacao.API.Domain.Model
{
    public class Evolucao : BaseModel
    {
        public Evolucao()
        {
        }

        public Evolucao(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, DateTime dataEvolucao, string pressaoInicial, string pressaoFinal, string observacao)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            DataEvolucao = dataEvolucao;
            PressaoInicial = pressaoInicial;
            PressaoFinal = pressaoFinal;
            Observacao = observacao;
        }
        public DateTime DataEvolucao { get; private set; }
        public string PressaoInicial { get; private set; }
        public string PressaoFinal { get; private set; }
        public string Observacao { get; private set; }

        public void setDataEvolucao(DateTime dataEvolucao) { this.DataEvolucao = dataEvolucao; }
        public void setPressaoInicial(string pressaoInicial) { this.PressaoInicial = pressaoInicial; }
        public void setPressaoFinal(string pressaoFinal) { this.PressaoFinal = pressaoFinal; }
        public void setObservacao(string observacao) { this.Observacao = observacao; }
    }
}
