using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class AnamneseDTO : BaseDTO
    {
        public AnamneseDTO()
        {
        }
        public string DiagnosticoClinico { get;  set; }
        public ProfissionalDTO Profissional { get;  set; }
        public string CID10 { get;  set; }
        public double Peso { get;  set; }
        public double Altura { get;  set; }
        public double IMC { get;  set; }
        public string QueixaPrincipal { get;  set; }
        public string HDA { get;  set; }
        public string MedicoResponsavel { get;  set; }
        public List<AntecedentesFamiliaresDTO> AntecedentesFamiliares { get;  set; }
        public List<AntecedentesPessoaisDTO> AntecedentesPessoais { get;  set; }
        public List<MedicamentoDTO> Medicamentos { get;  set; }

    }
}
