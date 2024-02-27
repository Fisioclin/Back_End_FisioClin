using Core.Util.Domain;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FichaAvaliacao.API.Domain.Interface
{
    public interface IProfissaoRepository : IBaseRepository<Profissao>
    {
        public Task<PageResult<Profissao>> ListaPaginado(ListaPaginadoFiltroDTO filtro, Guid companyId);
        public Task<List<Profissao>> ListaAutoCompletePorNome(ListaAutoCompleteFiltroDTO filtro, Guid companyId);

    }
}
