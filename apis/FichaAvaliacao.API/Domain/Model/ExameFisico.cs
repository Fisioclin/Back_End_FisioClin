using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class ExameFisico : BaseModel
    {
        public ExameFisico()
        {
            
        }

        public ExameFisico(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string inspecao, string palpacao)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Inspecao = inspecao;
            Palpacao = palpacao;

        }

        public string Inspecao { get; private set; }
        public string Palpacao { get; private set; }
        public ADM? ADM { get; private set; }
    }
}
