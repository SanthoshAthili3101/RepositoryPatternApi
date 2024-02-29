using RepositoryPatternApi.Data;
using RepositoryPatternApi.Models;
using RepositoryPatternApi.Repository.IUnitOfWork;

namespace RepositoryPatternApi.Repository.UnitOfWork
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
