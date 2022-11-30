namespace Mytra.DataAccess
{
    using Core;

    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        protected Microsoft.EntityFrameworkCore.DbContext DbContext { get; set; }
        public BaseRepository(Microsoft.EntityFrameworkCore.DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task AddAsync(T Entity)
        {
            await DbContext.Set<T>().AddAsync(Entity);
        }
    }
}