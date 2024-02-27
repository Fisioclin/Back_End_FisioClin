using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class PaisDTO : BaseDTO
    {
        public PaisDTO()
        {
        }

        public string Nome { get;  set; }
        public string Sigla { get;  set; }
    }
}
