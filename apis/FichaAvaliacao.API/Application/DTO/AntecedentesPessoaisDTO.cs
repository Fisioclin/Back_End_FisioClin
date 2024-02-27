using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class AntecedentesPessoaisDTO : BaseDTO
    {
        public AntecedentesPessoaisDTO()
        {
        }

        public string Nome { get;  set; }
        public string Descricao { get;  set; }
    }
}
