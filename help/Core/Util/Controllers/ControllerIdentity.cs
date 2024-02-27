using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Core.Util.Controllers
{
    public class Retorno
    {
        public Retorno(string titulo, string[] valor, int status)
        {
            Titulo = titulo;
            Valor = valor;
            Status = status;
        }

        public string Titulo { get; set; }
        public string[] Valor { get; set; }
        public int Status { get; set; }
    }

    [ApiController]
    public abstract class ControllerIdentity : Controller
    {
        protected ICollection<string> Erros = new List<string>();
        protected int status = 1;
        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }
            return BadRequest(
                new Retorno("Mensagens",Erros.ToArray(),status));
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);

            foreach (var erro in erros)
            {
                AdicionarErroProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }


        protected bool OperacaoValida()
        {
            return !Erros.Any();
        }

        protected void AdicionarErroProcessamento(string erro)
        {
            Erros.Add(erro);
        }

        protected void AdicionarErroStatusProcessamento(string erro, int status)
        {
            Erros.Add(erro);
            this.status = status;
        }

        protected void AdicionarStatusProcessamento(int status)
        {
            this.status = status;
        }

        protected void LimparErrosProcessamento()
        {
            Erros.Clear();
        }
    }
}
