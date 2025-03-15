namespace Mytra.Core
{
    public interface IUnitOfWork : IDisposable
    {
		Task<int> SaveChangesAsync();
    }
}