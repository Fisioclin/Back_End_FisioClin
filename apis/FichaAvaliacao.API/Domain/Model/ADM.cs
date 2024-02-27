using Core.Util.Domain;
using FichaAvaliacao.API.Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;


namespace FichaAvaliacao.API.Domain.Model
{
    public class ADM : BaseModel
    {
        public ADM()
        {
        }

        public ADM(int id, DateTime dataLancamento, DateTime dataAtualizacao, Guid usuarioCriacaoId, Guid usuarioAtualizacaoId, EnumEstado mSD, EnumEstado mSE, string goniometriaMsdMse, EnumEstado mID, EnumEstado mIE, string goniometriaMidMie, string perimetria, EnumEstado coluna, string goniometriaColuna, string testesEspeciais, AvaliacaoSubjetivaDor avaliacaoSubjetivaDor, List<TesteForcaMuscular> testeForcaMusculares, string examesComplementares)  
        {
            Id = id;
            DataLancamento = dataLancamento;
            DataAtualizacao = dataAtualizacao;
            UsuarioCriacaoId = usuarioCriacaoId;
            UsuarioAtualizacaoId = usuarioAtualizacaoId;
            MSD = mSD;
            MSE = mSE;
            GoniometriaMsdMse = goniometriaMsdMse;
            MID = mID;
            MIE = mIE;
            GoniometriaMidMie = goniometriaMidMie;
            Perimetria = perimetria;
            Coluna = coluna;
            GoniometriaColuna = goniometriaColuna;
            TestesEspeciais = testesEspeciais;
            AvaliacaoSubjetivaDor = avaliacaoSubjetivaDor;
            TesteForcaMusculares = testeForcaMusculares;
            ExamesComplementares = examesComplementares;

        }

        public EnumEstado MSD { get; private set; }
        public EnumEstado MSE { get; private set; }
        public string GoniometriaMsdMse { get; private set; }
        public EnumEstado MID { get; private set; }
        public EnumEstado MIE { get; private set; }
        public string GoniometriaMidMie { get; private set; }
        public string Perimetria { get; private set; }
        public EnumEstado Coluna { get; private set; }
        public string GoniometriaColuna { get; private set; }
        public string TestesEspeciais { get; private set; }
        public List<TesteForcaMuscular> TesteForcaMusculares { get; private set; }
        public AvaliacaoSubjetivaDor AvaliacaoSubjetivaDor { get; private set; }
        public string ExamesComplementares { get; private set; }
        [NotMapped]
        public List<int> EscalaAnalogicaDor { get; private set; }

        public void setAvaliacaoSubjetivaDor(AvaliacaoSubjetivaDor avaliacaoSubjetivaDor)
        {
            this.AvaliacaoSubjetivaDor = avaliacaoSubjetivaDor;
        }
    }
}
