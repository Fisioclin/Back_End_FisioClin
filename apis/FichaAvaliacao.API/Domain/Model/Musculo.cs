using FichaAvaliacao.API.Domain.Enum;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Domain.Model
{
    public class Musculo : BaseModel
    {
        public Musculo()
        {
        }

        public Musculo(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string descricao, string nome)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Descricao = descricao;
            Nome = nome;

        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }

    }
}
