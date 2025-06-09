

using Core.Domain.Common;

namespace Core.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new()
    {
        Task AddAsync(T entity);
        Task<IList<T>> AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entities);
        Task SoftDeleteAsync(T entity);
        Task SoftDeleteRangeAsync(IList<T> entities);
    }
}