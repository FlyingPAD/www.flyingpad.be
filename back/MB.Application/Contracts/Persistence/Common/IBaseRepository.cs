using System.Linq.Expressions;

namespace MB.Application.Contracts.Persistence.Common
{
    public interface IBaseRepository<T> where T : class
    {
        // Create
        Task<T> CreateAsync(T entity);

        // Retrieve
        Task<int> CountAsync();
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, object>>? orderBy = null, bool ascending = true);
        Task<T?> GetByBusinessIdAsync(Guid id);
        Task<int?> GetPrimaryIdByBusinessIdAsync(Guid? id);

        // Update
        Task UpdateAsync(T entity);

        // Delete
        Task DeleteAsync(T entity);
        Task DeleteMultipleAsync(IEnumerable<Guid> entityGuids);
    }
}

// TODO : Document this class