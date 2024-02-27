using System.ComponentModel.DataAnnotations.Schema;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class TesteForcaMuscular : BaseModel
    {
        public TesteForcaMuscular()
        {
        }

     

        public TesteForcaMuscular(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId,  Guid usuarioAtualizacaoId, string grau, Musculo musculo)        
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Grau = grau;
            Musculo = musculo;

        }
        public Musculo Musculo{ get; private set; }

        public string Grau { get; private set; }

        public void setGrau(string grau) { this.Grau = grau; }
    }
}
