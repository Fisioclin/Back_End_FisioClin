using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class ProfissaoDTO : BaseDTO
    {
        public ProfissaoDTO()
        {
        }

        public string Nome { get;  set; }
        public string Descricao { get;  set; }
    }
}
