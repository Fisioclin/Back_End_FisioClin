using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class TiposAntecedentesPessoais : BaseModel
    {
        public TiposAntecedentesPessoais()
        {
        }

        public TiposAntecedentesPessoais(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string nome, string descricao)
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
