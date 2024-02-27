using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace FichaAvaliacao.API.Domain.Model
{
    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public Cadastro(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, Guid CompanyId, string nome, EnumCor cor, EnumSexo sexo, DateTime dataNascimento, string profissao, string naturalidade, List<Ficha> fichas, List<Endereco> enderecos, string cPF, string rG, string email, string telefone, string empresa)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            this.CompanyId = CompanyId;
            Nome = nome;
            Cor = cor;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Naturalidade = naturalidade;
            Profissao = profissao;
            Fichas = fichas;
            Enderecos = enderecos;
            CPF = cPF;
            RG = rG;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public EnumCor Cor { get; private set; }
        public EnumSexo Sexo { get; private set; }
        public string Profissao { get; private set; }
        public string Empresa { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Naturalidade { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        [NotMapped]
        public List<Ficha>? Fichas { get; private set; }
        [NotMapped]
        public List<Endereco>? Enderecos { get; private set; }


        public void setNome(string nome) { this.Nome = nome; }
        public void setCor(EnumCor cor) { this.Cor = cor; }
        public void setSexo(EnumSexo sexo) { this.Sexo = sexo; }
        public void setProfissao(string profissao) { this.Profissao = profissao; }
        public void setEmpresa(string empresa) { this.Empresa = empresa; }
        public void setDataNascimento(DateTime dataNascimento) { this.DataNascimento = dataNascimento; }
        public void setNaturalidade(string naturalidade) { this.Naturalidade = naturalidade; }
        public void setCPF(string cPF) { this.CPF = cPF; }
        public void setRG(string rG) { this.RG = rG; }
        public void setEmail(string email) { this.Email = email; }
        public void setTelefone(string telefone) { this.Telefone = telefone; }
    }
}
