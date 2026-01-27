using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cosmos DB Configuration
            modelBuilder.Entity<Student>()
                .ToContainer("Students") 
                .HasPartitionKey(x => x.Id) 
                .HasNoDiscriminator(); 

            base.OnModelCreating(modelBuilder);
        }
    }
}