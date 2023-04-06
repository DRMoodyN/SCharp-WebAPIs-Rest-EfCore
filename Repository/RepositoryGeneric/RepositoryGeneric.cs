namespace Repository.RepositoryGeneric
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {
        private readonly WmsDbContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryGeneric(WmsDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<Object> AddAsync(T entity)
        {
            return await _dbSet.AddAsync(entity);
        }

        public async Task<bool> AnyPropertyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<List<T>> GetAllAsync<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "")
        {
            return await _dbSet.Where(predicate).OrderBy(selector).ToListAsync();
        }

        public IQueryable<T> GetAllInclude<K>(
            Expression<Func<T, bool>> predicate = null!,
            Expression<Func<T, K>> selector = null!,
            string includeRelation = "")
        {
            IQueryable<T> query = _dbSet;
            query = query.Where(predicate).OrderBy(selector).AsNoTracking();

            var incluyeArray = includeRelation.Split(
                new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var include in incluyeArray)
            {
                query = query.Include(include);
            }
            return query;
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
