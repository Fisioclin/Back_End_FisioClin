using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FichaAvaliacao.API.Domain.Model;


namespace FichaAvaliacao.API.Application.DTO
{
    public class CadastroDTO : BaseDTO
    {
        public CadastroDTO()
        {
        }

        public string Nome { get;  set; }
        public string CPF { get;  set; }
        public string RG { get;  set; }
        public EnumCor Cor { get;  set; }
        public EnumSexo Sexo { get;  set; }
        public string Profissao { get;  set; }
        public string Empresa { get; set; }
        public DateTime DataNascimento { get;  set; }
        public string Naturalidade { get;  set; }
        public string Email { get;  set; }
        public string Telefone { get;  set; }
        public List<Ficha>? Fichas { get;  set; }
        public List<Endereco>? Enderecos { get;  set; }
    }
}
