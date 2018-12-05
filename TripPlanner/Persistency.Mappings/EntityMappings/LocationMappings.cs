using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class LocationMappings : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
        }

        //public void Map(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Location>().HasKey(l => l.Id);

        //    //modelBuilder.Entity<Location>()
        //    //    .HasMany(t => t.Trips)
        //    //    .WithOne(l => l.Location);
        //}
    }
}
