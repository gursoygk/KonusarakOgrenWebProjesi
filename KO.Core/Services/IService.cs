using System.Linq.Expressions;

namespace KO.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> FindByID(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> GetAll(Expression<Func<T, bool>> experession);
        IQueryable<T> Where(Expression<Func<T, bool>> experession);
        Task<bool> AnyAsync(Expression<Func<T, bool>> experession);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        Task Update(T entity); //SavaChangeAsync metotunu kullanacağımız için geri dönüş tipleri Task olacak
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
    }
}
