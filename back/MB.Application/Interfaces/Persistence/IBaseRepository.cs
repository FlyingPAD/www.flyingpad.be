using System.Linq.Expressions;

namespace MB.Application.Interfaces.Persistence;

public interface IBaseRepository<T> where T : class
{
    // Count
    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);

    // Create
    Task<T> CreateAsync(T entity);

    // Get All
    Task<IQueryable<T>> GetAllAsync(
        Expression<Func<T, object>>? orderBy = null,
        bool ascending = true,
        bool shuffle = false);

    // Get By ID
    Task<T?> GetByBusinessIdAsync(Guid businessId, CancellationToken ct = default);
    Task<IEnumerable<T>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds, CancellationToken ct = default);
    Task<T?> GetByEntityIdAsync(int entityId, CancellationToken ct = default);
    Task<IEnumerable<T>> GetByEntityIdsAsync(IEnumerable<int> entityIds, CancellationToken ct = default);

    // Get ID
    Task<int?> GetEntityIdByBusinessIdAsync(Guid businessId, CancellationToken ct = default);
    Task<IEnumerable<int>> GetEntityIdsByBusinessIdsAsync(IEnumerable<Guid> businessIds, CancellationToken ct = default);

    // Update
    Task UpdateAsync(T entity);

    // Saves Changes
    Task SaveChangesAsync(CancellationToken cancellationToken = default);

    // Delete
    Task DeleteAsync(T entity);
    Task DeleteMultipleByBusinessIdsAsync(IEnumerable<Guid> businessIds);
    Task DeleteMultipleByEntityIdsAsync(IEnumerable<int> entityIds);
}