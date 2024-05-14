using MB.Application.Contracts.Persistence.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories.Common
{
    public class BaseRelationRepository<T> : BaseRepository<T>, IBaseRelationRepository<T> where T : class
    {
        protected readonly DbSet<T> _relationSet;

        public BaseRelationRepository(Context context) : base(context)
        {
            _relationSet = _context.Set<T>();
        }

        public async Task InsertRelationsAsync(int mainEntityId, List<int> relatedEntityIds, string mainEntityIdProperty, string relatedEntityIdProperty)
        {
            var existingRelations = await _relationSet
                .Where(relation => EF.Property<int>(relation, mainEntityIdProperty) == mainEntityId)
                .ToListAsync();

            _relationSet.RemoveRange(existingRelations);

            foreach (var relatedEntityId in relatedEntityIds)
            {
                var relation = Activator.CreateInstance<T>();
                _context.Entry(relation).Property(mainEntityIdProperty).CurrentValue = mainEntityId;
                _context.Entry(relation).Property(relatedEntityIdProperty).CurrentValue = relatedEntityId;
                await _relationSet.AddAsync(relation);
            }

            await _context.SaveChangesAsync();
        }

        public async Task DeleteRelationsByMainEntityIdAsync(int mainEntityId, string mainEntityIdProperty)
        {
            var relationsToDelete = await _relationSet
                .Where(relation => EF.Property<int>(relation, mainEntityIdProperty) == mainEntityId)
                .ToListAsync();

            if (relationsToDelete.Count != 0)
            {
                _relationSet.RemoveRange(relationsToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountRelationsByMainEntityIdAsync(int mainEntityId, string mainEntityIdProperty)
        {
            return await _relationSet
                .CountAsync(relation => EF.Property<int>(relation, mainEntityIdProperty) == mainEntityId);
        }
    }
}
