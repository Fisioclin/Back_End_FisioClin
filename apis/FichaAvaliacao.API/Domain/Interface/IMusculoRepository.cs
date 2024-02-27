using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface IMusculoRepository : IBaseRepository<Musculo>
    {
        public Task<PageResult<Musculo>> ListaPaginado(ListaPaginadoFiltroDTO filtro, Guid companyId);
        public Task<List<Musculo>> ListaAutoCompletePorNome(ListaAutoCompleteFiltroDTO filtro, Guid companyId);


    }
}
