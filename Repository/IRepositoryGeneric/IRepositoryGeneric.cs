
namespace Repository.IRepositoryGeneric
{
    public interface IRepositoryGeneric<T> where T : class
    {
        Task<List<T>> GetAllAsync<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "");

        IQueryable<T> GetAllInclude<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "");

        Task<Object> AddAsync(T entity);
        void Update(T entity);
        Task<bool> AnyPropertyAsync(Expression<Func<T, bool>> predicate);
    }
}
