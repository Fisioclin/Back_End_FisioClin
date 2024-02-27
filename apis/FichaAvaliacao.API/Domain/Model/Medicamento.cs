using FichaAvaliacao.API.Domain.Enum;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class Medicamento : BaseModel
    {
        public Medicamento()
        {
        }

        public Medicamento(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string descricao, string observacao, string nome)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Descricao = descricao;
            Observacao = observacao;
            Nome = nome;

        }


        public string Descricao { get; private set; }
        public string Observacao { get; private set; }
        public string Nome { get; private set; }

        public void setDescricao(string descricao)
        {
            this.Descricao = descricao;
        }

        public void setObservacao(string observacao)
        {
            this.Observacao = observacao;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }
    }
}
