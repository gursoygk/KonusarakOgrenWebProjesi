using System.Linq.Expressions;

namespace KO.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> FindByID(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
