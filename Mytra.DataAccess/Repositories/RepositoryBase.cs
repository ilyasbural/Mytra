namespace Mytra.DataAccess
{
    using Core;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;

    public abstract class RepositoryBase<T> : IRepository<T> where T : class, IEntity, new()
    {
        DbContext DbContext { get; set; }
        public RepositoryBase(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task InsertAsync(T Entity)
        {
            await DbContext.Set<T>().AddAsync(Entity);
        }

        public async Task UpdateAsync(T Entity)
        {
            await Task.Run(() => { DbContext.Set<T>().Update(Entity); });
        }

        public async Task DeleteAsync(T Entity)
        {
            await Task.Run(() => { DbContext.Set<T>().Remove(Entity); });
        }

        public async Task<List<T>> SelectAsync(Expression<Func<T, bool>> Predicate, params Expression<Func<T, object>>[] IncludeProperties)
        {
            IQueryable<T> Query = DbContext.Set<T>();

            if (Predicate != null) Query = Query.Where(Predicate);

            if (IncludeProperties.Any())
            {
                foreach (var property in IncludeProperties)
                {
                    Query = Query.Include(property);
                }
            }

            return await Query.ToListAsync();
        }
    }
}