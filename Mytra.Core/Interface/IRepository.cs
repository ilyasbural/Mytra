namespace Mytra.Core
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task InsertAsync(T Entity);
        Task InsertRangeAsync(List<T> Entities);
		Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<List<T>> SelectAsync(Expression<Func<T, bool>> Predicate, params Expression<Func<T, object>>[] IncludeProperties);
    }
}