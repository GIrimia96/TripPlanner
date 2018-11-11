using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class EmployeeTripMappings : IEntityMapping
    {
        public void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeTrip>()
                .HasKey(et => new { et.EmployeeId, et.TripId });

            modelBuilder.Entity<EmployeeTrip>()
                .HasOne(et => et.Employee)
                .WithMany(et => et.EmployeeTrips)
                .HasForeignKey(et => et.EmployeeId);


            modelBuilder.Entity<EmployeeTrip>()
                .HasOne(et => et.Trip)
                .WithMany(et => et.EmployeeTrips)
                .HasForeignKey(et => et.TripId);
        }
    }
}
