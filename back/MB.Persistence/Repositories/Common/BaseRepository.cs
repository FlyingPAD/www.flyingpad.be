using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MB.Persistence.Repositories.Common;

public class BaseRepository<T>(Context context) : IBaseRepository<T> where T : class
{
    protected readonly Context _context = context;

    public async Task<T> CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<int> CountAsync()
    {
        return await _context.Set<T>().CountAsync();
    }

    public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, object>>? orderBy = null, bool ascending = true)
    {
        IQueryable<T> query = _context.Set<T>();
        if (orderBy != null)
        {
            query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
        }
        return await Task.FromResult(query);
    }

    public async Task<T?> GetByBusinessIdAsync(Guid id)
    {
        return await _context.Set<T>().OfType<AuditableEntity>()
                                      .SingleOrDefaultAsync(x => x.BusinessId == id) as T;
    }

    public async Task<int?> GetPrimaryIdByBusinessIdAsync(Guid? id)
    {
        var entity = await _context.Set<T>().OfType<AuditableEntity>()
                                        .SingleOrDefaultAsync(x => x.BusinessId == id);
        return entity?.EntityId ?? null;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMultipleAsync(IEnumerable<Guid> entityGuids)
    {
        var entitiesToDelete = await _context.Set<AuditableEntity>()
            .Where(e => entityGuids.Contains(e.BusinessId))
            .ToListAsync();

        _context.Set<AuditableEntity>().RemoveRange(entitiesToDelete);
        await _context.SaveChangesAsync();
    }
}