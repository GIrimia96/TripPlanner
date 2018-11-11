using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class LocationMappings : IEntityMapping
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasKey(l => l.Id);

            modelBuilder.Entity<Location>()
                .HasMany(t => t.Trips)
                .WithOne(l => l.Location);
        }
    }
}
