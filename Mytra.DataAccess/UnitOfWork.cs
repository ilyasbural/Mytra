namespace Mytra.DataAccess
{
    using Core;

    public class UnitOfWork : IUnitOfWork
    {
        MytraContext DbContext;

        public UnitOfWork(MytraContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await DbContext.DisposeAsync();
        }
    }
}