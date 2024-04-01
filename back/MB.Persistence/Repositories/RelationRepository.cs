using MB.Application.Contracts.Persistence;
using MB.Domain.Entities;
using MB.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence.Repositories
{
    public class RelationRepository : BaseRepository<RelationArtistStyle>, IRelationRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"></param>
        public RelationRepository(Context context) : base(context)
        {

        }

        /// <summary>
        /// Insert Relations ' Artist / Style ' ( Async )
        /// </summary>
        /// <param name="artistId"></param>
        /// <param name="styleIds"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task RASInsertAsync(int artistId, List<int> styleIds)
        {
            // Delete existing relations

            var existingRelations = await _context.RArtistStyle
                .Where(relation => relation.ArtistId == artistId)
                .ToListAsync();

            _context.RArtistStyle.RemoveRange(existingRelations);

            // Add new relations

            foreach (var styleId in styleIds)
            {
                var relation = new RelationArtistStyle
                {
                    ArtistId = artistId,
                    StyleId = styleId
                };
                await _context.RArtistStyle.AddAsync(relation);
            }

            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete Relations By Style ID ( Async )
        /// </summary>
        /// <param name="styleId"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteRelationsByStyleIdAsync(int styleId)
        {
            var relationsToDelete = await _context.RArtistStyle
                .Where(relation => relation.StyleId == styleId)
                .ToListAsync();

            if (relationsToDelete.Any())
            {
                _context.RArtistStyle.RemoveRange(relationsToDelete);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Delete Relations By Artist ID ( Async )
        /// </summary>
        /// <param name="styleId"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteRelationsByArtistIdAsync(int artistId)
        {   
            var relationsToDelete = await _context.RArtistStyle
                .Where(relation => relation.ArtistId == artistId)
                .ToListAsync();

            if (relationsToDelete.Any())
            {
                _context.RArtistStyle.RemoveRange(relationsToDelete);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Check the number of relations for a specific style
        /// </summary>
        /// <param name="styleId"></param>
        /// <returns>Number of relations for the specified style</returns>
        public async System.Threading.Tasks.Task<int> CheckRelationsArtistStyleByStyle(int styleId)
        {
            return await _context.RArtistStyle
                .CountAsync(relation => relation.StyleId == styleId);
        }

        /// <summary>
        /// Check the number of relations for a specific artist
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns>Number of relations for the specified artist</returns>
        public async System.Threading.Tasks.Task<int> CheckRelationsArtistStyleByArtist(int artistId)
        {
            return await _context.RArtistStyle
                .CountAsync(relation => relation.ArtistId == artistId);
        }
    }
}