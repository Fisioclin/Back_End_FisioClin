using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class ProfissionalDTO : BaseDTO
    {
        public ProfissionalDTO()
        {
        }

        public string Profissao { get; set; }
        public string NumeroRegistro { get; set; }
        public int CadastroId { get; set; }
    }
}
