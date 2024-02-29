using RepositoryPatternApi.Data;
using RepositoryPatternApi.Models;
using RepositoryPatternApi.Repository.IUnitOfWork;

namespace RepositoryPatternApi.Repository.UnitOfWork
{
    public class DeveloperRepository : GenericRepository<User>, IUserRepository
    {
        public DeveloperRepository(ApplicationContext context) : base(context)
        {
        }
        public IEnumerable<User> GetPopularDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}
