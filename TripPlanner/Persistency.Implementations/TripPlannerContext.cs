using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistency.Implementations
{
    public class TripPlannerContext : DbContext
    {
        public TripPlannerContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts{ get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TripPlannerDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Account)
                .WithOne(i => i.Employee)
                .HasForeignKey<Account>(b => b.AccountForeignKey);
        }
    }
}
