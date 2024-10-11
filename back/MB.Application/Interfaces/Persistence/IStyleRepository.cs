using MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;

namespace MB.Application.Interfaces.Persistence;

public interface IStyleRepository : IBaseRepository<Style>
{
    Task<IEnumerable<GetStylesCheckBoxesByArtistQueryDto>> GetCheckBoxesByArtist(int artistId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}