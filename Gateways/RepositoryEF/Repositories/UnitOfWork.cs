using Entities.Interfaces;
using RepositoryEF.DataContext;

namespace RepositoryEF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductDbContext _context;

        public UnitOfWork(ProductDbContext context)
        {
            _context = context;
        }
        public Task<int> SaveChanges()
        {
            return _context.SaveChangesAsync();
        }
    }
}
