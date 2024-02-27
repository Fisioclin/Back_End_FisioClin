using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;


namespace FichaAvaliacao.API.Application.DTO
{
    public class EnderecoDTO : BaseDTO
    {
        public EnderecoDTO()
        {
        }
        public string Cidade { get;  set; }
        public string Logradouro { get;  set; }
        public string Numero { get;  set; }
        public string Bairro { get;  set; }
        public string Estado { get;  set; }
        public string Pais{ get;  set; }
        public string Cep { get;  set; }

    }
}
