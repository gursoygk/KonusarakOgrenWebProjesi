using KO.Core.UnitOfWorks;

namespace KO.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appContext;

        public UnitOfWork(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public void Commit()
        {
            _appContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appContext.SaveChangesAsync();
        }
    }
}
