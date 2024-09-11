using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.CountArtists;

public class CountArtistsQueryResponse : BaseResponse
{
    public int ArtistsCount { get; set; }

    public CountArtistsQueryResponse() : base ()
    {

    }
}
