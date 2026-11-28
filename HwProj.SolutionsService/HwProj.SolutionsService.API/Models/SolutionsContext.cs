using Microsoft.EntityFrameworkCore;

namespace HwProj.SolutionsService.API.Models
{
    public sealed class SolutionContext : DbContext
    {
        public DbSet<Solution> Solutions { get; set; }
        
        public DbSet<GithubSolutionCommit> LastGithubSolutionCommits { get; set; }

        public SolutionContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Solution>()
                .Property(n => n.StudentId)
                .HasMaxLength(450);

            modelBuilder.Entity<Solution>()
                .HasIndex(n => new { n.TaskId, n.StudentId, n.PublicationDate });
        }
    }
}
