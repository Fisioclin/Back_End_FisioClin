
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class Academico : BaseModel
    {
        public Academico()
        {
            
        }

        public Academico(Guid id, DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string nome, string matricula,  int cadastroId)
        {
            Id = id;
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Nome = nome;
            Matricula = matricula;
            CadastroId = cadastroId;
        }
        



        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public int CadastroId { get; private set; }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setMatricula(string matricula)
        {
            this.Matricula = matricula;
        }

        public void setCadastroId(int cadastroId)
        {
            this.CadastroId = cadastroId;
        }
    }
}
