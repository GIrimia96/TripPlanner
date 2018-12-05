namespace Repositories.Implementations
{
    using Entity.Models;
    using Persistency.Implementations;
    using Repositories.Contracts;
    using System;
    using System.Linq;

    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        public BaseRepository(TripPlannerContext dbContext)
        {
            DbContext = dbContext;
        }

        public TripPlannerContext DbContext { get; }

        public void Add(T entity)
        {
            this.DbContext.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid id)
        {
            return this.DbContext.Find<T>(id);
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            this.DbContext.SaveChanges();
        }
    }
}
