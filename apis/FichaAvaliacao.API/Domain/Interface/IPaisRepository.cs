using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface IPaisRepository : IBaseRepository<Pais>
    {
        public Task<PageResult<Pais>> ListaPaginado(ListaPaginadoFiltroDTO filtro, Guid companyId);
        public Task<List<Pais>> ListaAutoCompletePorNome(ListaAutoCompleteFiltroDTO filtro, Guid companyId);


    }
}
