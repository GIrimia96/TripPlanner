using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;
using System.Collections.Generic;

namespace Persistency.Implementations
{
    public class TripPlannerContext : DbContext
    {
        private readonly IEnumerable<IEntityMapping> _entityMappingCollection;

        public TripPlannerContext(IEnumerable<IEntityMapping> entityMappingCollection, DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            _entityMappingCollection = entityMappingCollection;
            Database.Migrate();
            TripPlannerDbSeeder.Seed(this);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TripPlannerDB;Trusted_Connection=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(p => p.Account)
                .WithOne(i => i.Employee)
                .HasForeignKey<Account>(b => b.AccountForeignKey);
        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    foreach (var entityMapping in _entityMappingCollection)
        //    {
        //        entityMapping.Map(modelBuilder);
        //    }
        //}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Document> Documents { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Trip> Trips { get; set; }
    }
}
