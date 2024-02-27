using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class AvaliacaoSubjetivaDorDTO : BaseDTO
    {
        public AvaliacaoSubjetivaDorDTO()
        {
        }

        public string Localizacao { get;  set; }
        public string Caracteristicas { get;  set; }
        public string Duracao { get;  set; }
        public string FatoresAgravantes { get;  set; }
        public string FatoresAtenuantes { get;  set; }
    }
}
