namespace Mytra.Core
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task InsertAsync(T Entity);
        Task UpdateAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task<List<T>> SelectAsync(System.Linq.Expressions.Expression<Func<T, bool>> Predicate);
        T Insert(T Entity);
        T Update(T Entity);
        T Delete(T Entity);
        List<T> Select(System.Linq.Expressions.Expression<Func<T, bool>> Predicate);
    }
}