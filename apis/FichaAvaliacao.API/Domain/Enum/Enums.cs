using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAvaliacao.API.Domain.Enum
{
    public enum EnumCor: int
    {
        BRANCO = 1,
        PARDO = 2,
        PRETO = 3,
        INDIGENA = 4,
        AMARELO = 5,
        OUTRO = 6
    }

    public enum EnumGrauParentesco : int
    {
        PAI = 1,
        MAE = 2,
        IRMAO = 3,
        IRMA = 4,
        PRIMA = 5,
        PRIMO = 6
    }

    public enum EnumSexo
    {
        FEMININO = 1,
        MASCULINO = 2,
        OUTRO = 3

    }

    public enum EnumEstado
    {
        NORMAL = 1,
        DIMINUIDA = 2

    }

    public enum EnumStatus
    {
        ATIVO = 1,
        INATIVO = 2

    }
}
