
namespace Repository.IRepositoryGeneric
{
    public interface IRepositoryGeneric<T> where T : class
    {
        Task<T> GetIdAsync(Expression<Func<T, bool>> predicate = null!);

        Task<List<T>> GetAllAsync<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "");

        IQueryable<T> GetAllInclude<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "");

        Task<T> AddAsync(T entity);
        void Update(T entity);
        Task<bool> AnyPropertyAsync(Expression<Func<T, bool>> predicate);
    }
}
