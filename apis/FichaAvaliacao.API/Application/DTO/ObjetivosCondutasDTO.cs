using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class ObjetivosCondutasDTO : BaseDTO
    {
        public string DiagnosticoTerapeutico { get; set; }
        public string ObjetivosTratamento { get; set; }
        public string CondutaFisioterapeutica { get; set; }
        public ProfissionalDTO Profissional { get; set; }
    }
}
