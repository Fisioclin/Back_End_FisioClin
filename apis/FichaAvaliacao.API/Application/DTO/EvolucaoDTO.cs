using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class EvolucaoDTO : BaseDTO
    {
        public EvolucaoDTO()
        {
        }



        public DateTime DataEvolucao { get; set; }
        public string PressaoInicial { get; set; }
        public string PressaoFinal { get; set; }
        public string Observacao { get; set; }
    }
}
