using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class ADMDTO : BaseDTO
    {
        public ADMDTO()
        {
        }

        public EnumEstado MSD { get;  set; }
        public EnumEstado MSE { get;  set; }
        public string GoniometriaMsdMse { get;  set; }
        public EnumEstado MID { get;  set; }
        public EnumEstado MIE { get;  set; }
        public string GoniometriaMidMie { get;  set; }
        public string Perimetria { get;  set; }
        public EnumEstado Coluna { get;  set; }
        public string GoniometriaColuna { get;  set; }
        public string TestesEspeciais { get;  set; }
        public List<TesteForcaMuscularDTO> TesteForcaMusculares { get;  set; }
        public AvaliacaoSubjetivaDorDTO AvaliacaoSubjetivaDor { get;  set; }
        public string ExamesComplementares { get; set; }
        public int[] EscalaAnalogicaDor { get; set; }


    }
}
