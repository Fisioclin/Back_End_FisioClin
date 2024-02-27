using Core.Util.Data;

namespace Core.Util.Domain
{
    public interface IBaseRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
        public Task<List<T>> GetAsync(Guid companyId);

        public Task<T?> GetAsync(int id, Guid companyId);

        public Task<int> CreateAsync(T novo);

        public Task<T> UpdateAsync(T atualizar);


        public void RemoveAsync(int id);

    }
}
