namespace Mytra.Core
{
    public interface IUnitOfWork
    {
        IAnnounceRepository Announce { get; }
        IAnnounceDetailRepository AnnounceDetail { get; }
        ICategoryRepository Category { get; }
        Task<int> SaveChangesAsync();
    }
}