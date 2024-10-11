using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.GetAllArtists;

public class GetAllArtistsQueryResponse : BaseResponse
{
    public List<GetAllArtistsQueryDto> Artists { get; set; } = [];
}