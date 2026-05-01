using Microsoft.EntityFrameworkCore;
using TaskPlanner.API.Models;
using Task = TaskPlanner.API.Models.Task;

namespace TaskPlanner.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Name)
                .IsUnique();
        }
    }
}
