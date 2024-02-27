using FichaAvaliacao.API.Domain.Enum;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class Profissional : BaseModel
    {
        public Profissional()
        {
        }

        public Profissional(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string numeroRegistro, int cadastroId, string profissao)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Profissao = profissao;
            NumeroRegistro = numeroRegistro;
            CadastroId = cadastroId;
        }

        public string Profissao{ get; private set; }
        public string NumeroRegistro { get; private set; }
        public int CadastroId { get; private set; }

        public void setProfissao(string profissao)
        {
            this.Profissao = profissao;
        }

        public void setNumeroRegistro(string numeroRegistro)
        {
            this.NumeroRegistro = numeroRegistro;
        }

        public void setCadastroId(int cadastroId)
        {
            this.CadastroId = cadastroId;
        }
    }
}
