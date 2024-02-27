using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class AntecedentesFamiliares : BaseModel
    {
        public AntecedentesFamiliares()
        {
        }

        public AntecedentesFamiliares(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string nome, string observacao)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Nome = nome;
            Observacao = observacao;

        }

        public string Nome { get; private set; }
        public string Observacao { get; private set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setObservacao(string observacao)
        {
            this.Observacao = observacao;
        }
    }
}
