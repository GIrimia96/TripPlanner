using Entity.Models;

namespace Repositories.Contracts
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add(T entity);

        void Save();
    }
}
