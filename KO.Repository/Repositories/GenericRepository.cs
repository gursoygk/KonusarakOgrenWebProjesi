using KO.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KO.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entity)
        {
            await _dbSet.AddRangeAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> experession)
        {
            return await _dbSet.AnyAsync(experession);
        }

        public async Task<T> FindByID(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> experession)
        {
            return _dbSet.AsNoTracking().AsQueryable(); //AsNoTracking EfCore çektiği verileri belleğe almayıp daha hızlı çalışsın
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> experession)
        {
            return _dbSet.Where(experession);
        }
    }
}
