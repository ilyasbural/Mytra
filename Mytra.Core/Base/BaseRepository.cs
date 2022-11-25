namespace Mytra.Core
{
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly DbContext DbContext;
        public BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public Task AddAsync(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}