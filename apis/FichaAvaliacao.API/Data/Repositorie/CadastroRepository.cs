
using Core.Util.Data;
using Core.Util.Model;
using FichaAvaliacao.API.Application.DTO.Filtro;
using FichaAvaliacao.API.Data.Context;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace FichaAvaliacao.API.Data.Repositories
{
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        private readonly BDContext _context;
        public CadastroRepository(BDContext context) : base(context)
        {
            _context = context;
        }
        public Task<PageResult<Cadastro>> ListaPaginado(ListaPaginadoFiltroDTO filtro, Guid companyId)
        {
            throw new NotImplementedException();
        }

        public override async Task<int> CreateAsync(Cadastro novo)
        {
            novo.Status = 1;
            await _context.Cadastros.AddAsync(novo);
            return novo.Id;
        }

        public async override Task<List<Cadastro>> GetAsync(Guid companyId)
        {
            return await _context.Cadastros
                .Where(c => c.CompanyId == companyId)
                .ToListAsync();
        }

        public async override Task<Cadastro?> GetAsync(int id, Guid companyId)
        {
            return await _context.Cadastros
                .FirstOrDefaultAsync(c => c.Id == id && c.CompanyId == companyId);
        }

        public virtual async void RemoveAsync(int id, Guid companyId)
        {
            var registro = await GetAsync(id, companyId);
            if (!registro.Equals(null))
            {
                return;
            }
            _context.Cadastros.Remove(registro);
        }

        public async virtual Task<Cadastro> UpdateAsync(Cadastro atualizar)
        {
            _context.Cadastros.Update(atualizar);
            return atualizar;
        }
    }
}
