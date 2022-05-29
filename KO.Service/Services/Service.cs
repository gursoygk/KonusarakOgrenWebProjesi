using KO.Core.Repositories;
using KO.Core.Services;
using KO.Core.UnitOfWorks;

namespace KO.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitofwork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitofwork)
        {
            _repository = repository;
            _unitofwork = unitofwork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitofwork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitofwork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task<T> FindByID(int id)
        {
            return await _repository.FindByID(id);
        }

        public IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _repository.GetAll(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task Remove(T entity)
        {
            _repository.Remove(entity);
            await _unitofwork.CommitAsync();
        }

        public async Task RemoveRange(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _unitofwork.CommitAsync();
        }

        public async Task Update(T entity)
        {
            _repository.Update(entity);
            await _unitofwork.CommitAsync();
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
