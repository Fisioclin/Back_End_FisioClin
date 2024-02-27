namespace Core.Util.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
