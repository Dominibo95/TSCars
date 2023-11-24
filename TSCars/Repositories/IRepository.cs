
using TSCars.Entities;

namespace TSCars.Repositories
{
    public interface IRepository<T> : IReadRepository<T> , IWriteRepository<T>
    where T : class, IEntity
    { }

}
