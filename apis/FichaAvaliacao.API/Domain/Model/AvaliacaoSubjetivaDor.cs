using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;


namespace FichaAvaliacao.API.Domain.Model
{
    public class AvaliacaoSubjetivaDor : BaseModel
    {
        public AvaliacaoSubjetivaDor()
        {
        }

        public AvaliacaoSubjetivaDor(DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, string localizacao, string caracteristicas, string duracao, string fatoresAgravantes, string fatoresAtenuantes)
        {
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            Localizacao = localizacao;
            Caracteristicas = caracteristicas;
            Duracao = duracao;
            FatoresAgravantes = fatoresAgravantes;
            FatoresAtenuantes = fatoresAtenuantes;

        }

        public string Localizacao { get; private set; }
        public string Caracteristicas { get; private set; }
        public string Duracao { get; private set; }
        public string FatoresAgravantes { get; private set; }
        public string FatoresAtenuantes { get; private set; }


        public void setLocalizacao (string localizacao){this.Localizacao = localizacao;}
        public void setCaracteristicas (string caracteristicas){this.Caracteristicas =caracteristicas;}
        public void setDuracao (string duracao){this.Duracao =duracao;}
        public void setFatoresAgravantes (string fatoresAgravantes){this.FatoresAgravantes =fatoresAgravantes;}
        public void setFatoresAtenuantes (string fatoresaAtenuantes){this.FatoresAtenuantes =fatoresaAtenuantes;}
    }
}
