using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface IEstadoRepository : IBaseRepository<Estado>
    {

        public Task<PageResult<Estado>> ListaPaginado(ListaPaginadoFiltroDTO filtro,Guid companyId);
        public Task<List<Estado>> ListaAutoCompletePorNome(ListaAutoCompleteFiltroDTO filtro,Guid companyId);

    }
}
