using MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;
using MB.Domain.StyleAggregate;

namespace MB.Application.Interfaces.Persistence.Definitions;

public interface IStyleRepository : IBaseRepository<Style>
{
    Task<IEnumerable<GetStylesCheckBoxesByArtistQueryDto>> GetCheckBoxesByArtist(int artistId);
    Task<List<int>> GetPrimaryIdsByBusinessIdsAsync(List<Guid> businessIds);
}