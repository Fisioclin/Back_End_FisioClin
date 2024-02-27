using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class AntecedentesFamiliaresDTO : BaseDTO
    {
        public AntecedentesFamiliaresDTO()
        {
        }

        public string Nome { get; set; }
        public string Observacao { get; set; }
    }
}
