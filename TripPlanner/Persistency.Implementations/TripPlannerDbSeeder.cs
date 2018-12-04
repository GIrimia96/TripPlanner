namespace Persistency.Implementations
{
    public static class TripPlannerDbSeeder
    {
        public static void Seed(TripPlannerContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
