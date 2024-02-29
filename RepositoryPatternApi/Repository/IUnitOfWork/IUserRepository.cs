using RepositoryPatternApi.Models;

namespace RepositoryPatternApi.Repository.IUnitOfWork
{
    public interface IUserRepository : IGenericRepository<User>
    {
        IEnumerable<User> GetPopularDevelopers(int count);
    }
}
