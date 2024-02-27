using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;
using Microsoft.AspNetCore.Components.Forms;

namespace FichaAvaliacao.API.Application.DTO
{
    public class ExameFisicoDTO : BaseDTO
    {
        public ExameFisicoDTO()
        {
        }

        public string Inspecao { get;  set; }
        public string Palpacao { get;  set; }
        public ADMDTO? ADM { get; set; }
    }
}
