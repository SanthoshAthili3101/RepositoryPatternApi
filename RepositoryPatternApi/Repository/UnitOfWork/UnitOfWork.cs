

using RepositoryPatternApi.Data;
using RepositoryPatternApi.Repository.IUnitOfWork;

namespace RepositoryPatternApi.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWorkRP
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Developers = new DeveloperRepository(_context);
            Projects = new ProjectRepository(_context);
        }
        public IUserRepository Developers { get; private set; }
        public IProjectRepository Projects { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
