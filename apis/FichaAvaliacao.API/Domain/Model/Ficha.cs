using FichaAvaliacao.API.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Util.Domain;
namespace FichaAvaliacao.API.Domain.Model
{
    public class Ficha : BaseModel
    {
        public Ficha()
        {
        }

        public Ficha(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, DateTime dataAvaliacao, Anamnese anamnese, ExameFisico exameFisico, ObjetivosCondutas objetivosConduta, List<Evolucao> evolucaos)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            DataAvaliacao = dataAvaliacao;
            Anamnese = anamnese;
            ExameFisico = exameFisico;
            ObjetivosConduta = objetivosConduta;
            Evolucaos = evolucaos;
        }

        public DateTime DataAvaliacao { get; private set; }
        public Anamnese? Anamnese { get; private set; }
        public ExameFisico? ExameFisico { get; private set; }
        public ObjetivosCondutas? ObjetivosConduta { get; private set; }
        public List<Evolucao>? Evolucaos { get; private set; }

        public void setAnamnese(Anamnese anamnese)
        {
            this.Anamnese = anamnese;
        }

        public void setAvaliacao(ExameFisico exameFisico)
        {
            this.ExameFisico = exameFisico;
        }

        public void setObjetivosConduta(ObjetivosCondutas objetivosConduta)
        {
            this.ObjetivosConduta = objetivosConduta;
        }

        public void setDataAvaliacao(DateTime dataAvaliacao)
        {
            this.DataAvaliacao = dataAvaliacao;
        }

    }
}
