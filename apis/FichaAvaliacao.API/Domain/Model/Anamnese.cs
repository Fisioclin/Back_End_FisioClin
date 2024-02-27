using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class Anamnese : BaseModel
    {
        public Anamnese()
        {
        }

        public Anamnese(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string diagnosticoClinico, string cID10, double peso, double altura, double iMC, string queixaPrincipal, string hDA, Profissional profissional, List<AntecedentesFamiliares> antecedentesFamiliares, List<AntecedentesPessoais> antecedentesPessoais, List<Medicamento> medicamentos)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            DiagnosticoClinico = diagnosticoClinico;
            Profissional = profissional;
            CID10 = cID10;
            Peso = peso;
            Altura = altura;
            IMC = iMC;
            QueixaPrincipal = queixaPrincipal;
            HDA = hDA;
            AntecedentesFamiliares = antecedentesFamiliares;
            AntecedentesPessoais = antecedentesPessoais;
            Medicamentos = medicamentos;

        }

        public string DiagnosticoClinico { get; private set; }
        public Profissional? Profissional { get; private set; }
        public string CID10 { get; private set; }
        public double Peso { get; private set; }
        public double Altura { get; private set; }
        public double IMC { get; private set; }
        public string QueixaPrincipal { get; private set; }
        public string HDA { get; private set; }
        public string MedicoResponsavel { get; private set; }
        public List<AntecedentesFamiliares>? AntecedentesFamiliares { get; private set; }
        public List<AntecedentesPessoais>? AntecedentesPessoais { get; private set; }
        public List<Medicamento>? Medicamentos { get; private set; }

        public void setDiagnosticoClinico(string diagnosticoClinico){this.DiagnosticoClinico = diagnosticoClinico;}
        public void setCID10(string cID10){this.CID10 = cID10;}
        public void setPeso(double peso) { this.Peso = peso; }
        public void setAltura(double altura) { this.Altura = altura; }
        public void setIMC(double iMC) { this.IMC = iMC; }
        public void setQueixaPrincipal(string queixaPrincipal) { this.QueixaPrincipal = queixaPrincipal; }
        public void setHDA(string hDA) { this.HDA = hDA; }
        public void setMedicoResponsavel(string medicoResponsavel) { this.MedicoResponsavel = medicoResponsavel; }
    }
}
