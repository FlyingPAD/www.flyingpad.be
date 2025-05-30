using System.Linq.Expressions;
using MB.Application.Interfaces.Persistence;
using MB.Domain;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories;

public class BaseRepository<T>(Context context) : IBaseRepository<T> where T : class
{
    protected readonly Context _context = context;

    // Count
    public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
    {
        IQueryable<T> query = _context.Set<T>();
        if (predicate is not null)
            query = query.Where(predicate);
        return await query.CountAsync();
    }

    // Create
    public async Task<T> CreateAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    // Get All
    public Task<IQueryable<T>> GetAllAsync(
        Expression<Func<T, object>>? orderBy = null,
        bool ascending = true,
        bool shuffle = false)
    {
        IQueryable<T> query = _context.Set<T>();
        if (shuffle)
        {
            query = query.OrderBy(_ => Guid.NewGuid());
        }
        else if (orderBy is not null)
        {
            query = ascending
                ? query.OrderBy(orderBy)
                : query.OrderByDescending(orderBy);
        }
        return Task.FromResult(query);
    }

    // Get By ID
    public async Task<T?> GetByBusinessIdAsync(Guid businessId, CancellationToken ct = default)
    {
        var ent = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .SingleOrDefaultAsync(e => e.BusinessId == businessId, ct);
        return ent as T;
    }

    public async Task<IEnumerable<T>> GetByBusinessIdsAsync(IEnumerable<Guid> businessIds, CancellationToken ct = default)
    {
        var list = await _context.Set<T>()
            .AsTracking()
            .OfType<AuditableEntity>()
            .Where(e => businessIds.Contains(e.BusinessId))
            .ToListAsync(ct);
        return list.Cast<T>();
    }

    public async Task<T?> GetByEntityIdAsync(int entityId, CancellationToken ct = default)
    {
        var ent = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .SingleOrDefaultAsync(e => e.EntityId == entityId, ct);
        return ent as T;
    }

    public async Task<IEnumerable<T>> GetByEntityIdsAsync(IEnumerable<int> entityIds, CancellationToken ct = default)
    {
        var list = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .Where(e => entityIds.Contains(e.EntityId))
            .ToListAsync(ct);
        return list.Cast<T>();
    }

    // Get ID
    public async Task<int?> GetEntityIdByBusinessIdAsync(Guid businessId, CancellationToken ct = default)
    {
        var entId = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .Where(e => e.BusinessId == businessId)
            .Select(e => (int?)e.EntityId)
            .SingleOrDefaultAsync(ct);
        return entId;
    }

    public async Task<IEnumerable<int>> GetEntityIdsByBusinessIdsAsync(IEnumerable<Guid> businessIds, CancellationToken ct = default)
    {
        return await _context.Set<T>()
            .OfType<AuditableEntity>()
            .Where(e => businessIds.Contains(e.BusinessId))
            .Select(e => e.EntityId)
            .ToListAsync(ct);
    }

    // Update
    public async Task UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    // Save Changes
    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync(cancellationToken);
    }

    // Delete
    public async Task DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMultipleByBusinessIdsAsync(IEnumerable<Guid> businessIds)
    {
        var toDelete = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .Where(e => businessIds.Contains(e.BusinessId))
            .Cast<T>()
            .ToListAsync();
        _context.Set<T>().RemoveRange(toDelete);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteMultipleByEntityIdsAsync(IEnumerable<int> entityIds)
    {
        var toDelete = await _context.Set<T>()
            .OfType<AuditableEntity>()
            .Where(e => entityIds.Contains(e.EntityId))
            .Cast<T>()
            .ToListAsync();
        _context.Set<T>().RemoveRange(toDelete);
        await _context.SaveChangesAsync();
    }
}