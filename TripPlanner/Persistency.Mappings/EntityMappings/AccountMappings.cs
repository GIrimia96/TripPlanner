using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class AccountMappings : IEntityMapping
    {

        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey(a => a.Id);

            modelBuilder.Entity<Account>()
                .HasOne(e => e.Employee)
                .WithOne();

            modelBuilder.Entity<Account>()
                .Property(a => a.Password)
                .IsRequired();

            modelBuilder.Entity<Account>()
                .Property(a => a.Username)
                .IsRequired();
        }
    }
}
