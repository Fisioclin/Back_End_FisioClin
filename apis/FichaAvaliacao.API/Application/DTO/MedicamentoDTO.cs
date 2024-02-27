using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class MedicamentoDTO : BaseDTO
    {
        public MedicamentoDTO()
        {
        }

        public string Descricao { get;  set; }
        public string Observacao { get;  set; }
        public string Nome { get;  set; }
    }
}
