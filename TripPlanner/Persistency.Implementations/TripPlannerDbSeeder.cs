using Entity.Models;
using System;

namespace Persistency.Implementations
{
    public static class TripPlannerDbSeeder
    {
        private static readonly Guid EmployeeAcc = Guid.NewGuid();

        public static void Seed(TripPlannerContext context)
        {

            context.Database.EnsureCreated();


            context.SaveChanges();
        }
    }
}
