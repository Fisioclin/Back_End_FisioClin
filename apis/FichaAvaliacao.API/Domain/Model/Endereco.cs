using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class Endereco : BaseModel
    {
        public Endereco()
        {
        }

        public Endereco(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string cidade, string logradouro, string numero, string bairro, string estado, string pais,  string cep)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Cidade = cidade;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Estado = estado;
            Pais = pais;
            Cep = cep;

        }
        public string Cidade { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }

        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public void setLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }

        public void setNumero(string numero)
        {
            this.Numero = numero;
        }

        public void setBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public void setEstado(string estado)
        {
            this.Estado = estado;
        }

        public void setPais(string pais)
        {
            this.Pais = pais;
        }

        public void setCep(string cep)
        {
            this.Cep = cep;
        }

    }
}
