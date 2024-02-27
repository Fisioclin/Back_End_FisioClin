using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface IMedicamentoRepository : IBaseRepository<Medicamento>
    {
        public Task<PageResult<Medicamento>> ListaPaginado(ListaPaginadoFiltroDTO filtro, Guid companyId);
        public Task<List<Medicamento>> ListaAutoCompletePorNome(ListaAutoCompleteFiltroDTO filtro, Guid companyId);


    }
}
