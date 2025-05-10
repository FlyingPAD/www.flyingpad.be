using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQueryResponse : BaseResponse
{
    public GetArtistByIdQueryDto Artist { get; set; } = new();
}