using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Persistency.Contracts;

namespace Persistency.Mappings.EntityMappings
{
    public class EmployeeMappings : IEntityMapping
    {
        public void Map(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);

        }
    }
}
