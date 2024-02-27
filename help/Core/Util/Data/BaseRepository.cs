using Core.Util.Domain;

namespace Core.Util.Data
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        private readonly BDContextModel _context;
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="context">Context</param>
        public BaseRepository(BDContextModel context)
        {
            _context = context;
        }

        /// <summary>
        /// Unidade de Trabalho
        /// </summary>
        public IUnitOfWork UnitOfWork => _context;

        public virtual Task<int> CreateAsync(T novo)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<T>> GetAsync(Guid companyId)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T?> GetAsync(int id, Guid companyId)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> UpdateAsync(T atualizar)
        {
            throw new NotImplementedException();
        }
    }
}