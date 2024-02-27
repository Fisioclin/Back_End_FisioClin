using FichaAvaliacao.API.Domain.Enum;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class ObjetivosCondutas : BaseModel
    {
        public ObjetivosCondutas()
        {
        }

       

        public ObjetivosCondutas(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string diagnosticoTerapeutico, string objetivosTratamento, string condutaFisioterapeutica, Profissional profissional)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            DiagnosticoTerapeutico = diagnosticoTerapeutico;
            ObjetivosTratamento = objetivosTratamento;
            CondutaFisioterapeutica = condutaFisioterapeutica;
            Profissional = profissional;
        }

        public string DiagnosticoTerapeutico { get; private set; }
        public string ObjetivosTratamento { get; private set; }
        public string CondutaFisioterapeutica { get; private set; }
        public Profissional Profissional { get; private set; }

        public void setDiagnosticoTerapeutico(string diagnosticoTerapeutico) { this.DiagnosticoTerapeutico = diagnosticoTerapeutico; }
        public void setObjetivosTratamento(string objetivosTratamento) { this.ObjetivosTratamento = objetivosTratamento; }
        public void setCondutaFisioterapeutica(string condutaFisioterapeutica) { this.CondutaFisioterapeutica = condutaFisioterapeutica; }

    }
}
