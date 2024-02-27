using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class MusculoDTO : BaseDTO
    {
        public MusculoDTO()
        {
        }

        public string Descricao { get;  set; }
        public string Nome { get;  set; }


    }
}
