using MB.Application.Responses;

namespace MB.Application.Features.Artists.Queries.GetArtists;

public class GetArtistsQueryResponse : BaseResponse
{
    public List<GetArtistsVm> Artists { get; set; } = [];
}
