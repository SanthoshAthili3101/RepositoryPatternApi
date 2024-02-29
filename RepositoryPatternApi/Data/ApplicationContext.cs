using Microsoft.EntityFrameworkCore;
using RepositoryPatternApi.Models;

namespace RepositoryPatternApi.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<User> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
