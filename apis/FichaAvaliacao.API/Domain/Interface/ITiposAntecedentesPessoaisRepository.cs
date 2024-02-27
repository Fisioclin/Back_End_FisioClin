using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface ITiposAntecedentesPessoaisRepository : IBaseRepository<TiposAntecedentesPessoais>
    {
        public Task<PageResult<TiposAntecedentesPessoais>> ListaPaginado(ListaPaginadoFiltroDTO filtro,Guid companyId);

    }
}
