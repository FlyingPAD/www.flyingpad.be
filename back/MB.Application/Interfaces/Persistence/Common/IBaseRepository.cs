using System.Linq.Expressions;

namespace MB.Application.Interfaces.Persistence.Common;

public interface IBaseRepository<T> where T : class
{
    Task<T> CreateAsync(T entity);

    Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    Task<IQueryable<T>> GetAllAsync(
    Expression<Func<T, object>>? orderBy = null,
    bool ascending = true,
    bool shuffle = false);
    Task<T?> GetByBusinessIdAsync(Guid id);
    Task<int?> GetPrimaryIdByBusinessIdAsync(Guid? id);

    Task UpdateAsync(T entity);

    Task DeleteAsync(T entity);
    Task DeleteMultipleAsync(IEnumerable<Guid> entityGuids);
}