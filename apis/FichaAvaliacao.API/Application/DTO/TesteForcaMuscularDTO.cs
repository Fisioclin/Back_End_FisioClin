using Core.Util.Application;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Application.DTO
{
    public class TesteForcaMuscularDTO : BaseDTO
    {
        public TesteForcaMuscularDTO()
        {
        }

        public MusculoDTO Musculo { get; set; }
        public string Grau { get; set; }
    }
}
