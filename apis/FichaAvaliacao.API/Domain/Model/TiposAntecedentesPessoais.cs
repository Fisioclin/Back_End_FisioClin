using FichaAvaliacao.API.Domain.Enum;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class AntecedentesPessoais : BaseModel
    {
        public AntecedentesPessoais()
        {
        }

        public AntecedentesPessoais(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string nome, string descricao)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Nome = nome;
            Descricao = descricao;

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public void setNome (string  nome){this.Nome = nome;}
        public void setDescricao(string  descricao){this.Descricao = descricao;}
    }
}
