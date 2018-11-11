using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class TripMappings : IEntityMapping
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasKey(t => t.Id);

            modelBuilder.Entity<Trip>()
                .HasOne(l => l.Location)
                .WithMany(t => t.Trips)
                .HasForeignKey(t => t.Id);

        }
    }
}
