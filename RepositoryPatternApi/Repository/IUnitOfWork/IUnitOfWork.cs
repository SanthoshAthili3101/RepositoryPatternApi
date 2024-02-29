using RepositoryPatternApi.Repository.UnitOfWork;

namespace RepositoryPatternApi.Repository.IUnitOfWork
{
    public interface IUnitOfWorkRP : IDisposable
    {
        IUserRepository Developers { get; }
        IProjectRepository Projects { get; }
        int Complete();
    }
}
