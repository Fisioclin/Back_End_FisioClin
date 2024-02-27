using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class Estado : BaseModel
    {
        public Estado()
        {
        }

        public Estado(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string nome, string sigla)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Nome = nome;
            Sigla = sigla;

        }

        public string Nome { get; private set; }
        public string Sigla { get; private set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setSigla(string sigla)
        {
            this.Sigla = sigla;
        }
    }
}
