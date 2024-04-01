using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Contracts.Persistence
{
    public interface IRelationRepository : IBaseRepository<RelationArtistStyle>
    {
        System.Threading.Tasks.Task RASInsertAsync(int artistId, List<int> styleIds);
        System.Threading.Tasks.Task DeleteRelationsByStyleIdAsync(int styleId);
        System.Threading.Tasks.Task DeleteRelationsByArtistIdAsync(int artistId);
        System.Threading.Tasks.Task<int> CheckRelationsArtistStyleByStyle(int styleId);
        System.Threading.Tasks.Task<int> CheckRelationsArtistStyleByArtist(int artistId);
    }
}