using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MB.Persistence.Repositories.Common
{
    public class BaseRepository<T>(Context context) : IBaseRepository<T> where T : class
    {
        protected readonly Context _context = context;

        /// <summary>
        /// Adds and saves an entity.
        /// </summary>
        public async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        /// <summary>
        /// Counts entities of type T.
        /// </summary>
        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        /// <summary>
        /// Returns all entities of type T, optionally ordered.
        /// </summary>
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, object>>? orderBy = null, bool ascending = true)
        {
            IQueryable<T> query = _context.Set<T>();
            if (orderBy != null)
            {
                query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);
            }
            return await Task.FromResult(query);
        }

        /// <summary>
        /// Retrieves an entity by business ID.
        /// </summary>
        public async Task<T?> GetByBusinessIdAsync(Guid id)
        {
            return await _context.Set<T>().OfType<AuditableEntity>()
                                          .SingleOrDefaultAsync(x => x.BusinessId == id) as T;
        }

        /// <summary>
        /// Gets the primary key by business ID.
        /// </summary>
        public async Task<int?> GetPrimaryIdByBusinessIdAsync(Guid? id)
        {
            var entity = await _context.Set<T>().OfType<AuditableEntity>()
                                            .SingleOrDefaultAsync(x => x.BusinessId == id);
            return entity?.EntityId ?? null;
        }

        /// <summary>
        /// Updates and saves an entity.
        /// </summary>
        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes an entity.
        /// </summary>
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes multiple entities by business IDs.
        /// </summary>
        public async Task DeleteMultipleAsync(IEnumerable<Guid> entityGuids)
        {
            var entitiesToDelete = await _context.Set<AuditableEntity>()
                .Where(e => entityGuids.Contains(e.BusinessId))
                .ToListAsync();

            _context.Set<AuditableEntity>().RemoveRange(entitiesToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
