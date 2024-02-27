using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class FichaDTO : BaseDTO
    {
        public FichaDTO()
        {
        }

        public DateTime DataAvaliacao { get; set; }
        public AnamneseDTO Anamnese { get; set; }
        public ExameFisicoDTO ExameFisico { get; set; }
        public ObjetivosCondutasDTO ObjetivosConduta { get; set; }
        public List<EvolucaoDTO> Evolucaos { get; set; }

    }
}
