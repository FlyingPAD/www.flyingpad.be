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

    public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
    {
        IQueryable<T> query = _context.Set<T>();

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return await query.CountAsync();
    }

    public async Task<IQueryable<T>> GetAllAsync(
        Expression<Func<T, object>>? orderBy = null,
        bool ascending = true,
        bool shuffle = false)
    {
        IQueryable<T> query = _context.Set<T>();

        if (shuffle)
        {
            query = query.OrderBy(_ => Guid.NewGuid());
        }
        else if (orderBy != null)
        {
            query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
        }

        return await Task.FromResult(query);
    }

    public async Task<T?> GetByBusinessIdAsync(Guid id)
    {
        return await _context.Set<T>().OfType<AuditableEntity>()
                                      .SingleOrDefaultAsync(entity => entity.BusinessId == id) as T;
    }

    public async Task<int?> GetPrimaryIdByBusinessIdAsync(Guid? id)
    {
        var entity = await _context.Set<T>().OfType<AuditableEntity>()
                                        .SingleOrDefaultAsync(entity => entity.BusinessId == id);
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
            .Where(entity => entityGuids.Contains(entity.BusinessId))
            .ToListAsync();

        _context.Set<AuditableEntity>().RemoveRange(entitiesToDelete);
        await _context.SaveChangesAsync();
    }
}