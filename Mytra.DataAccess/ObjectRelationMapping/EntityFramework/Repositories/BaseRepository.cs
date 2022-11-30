namespace Mytra.DataAccess
{
    using Core;
    using System.Linq.Expressions;

    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        protected readonly MytraContext DbContext;
        public BaseRepository(MytraContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}