using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.CountArtists;

public class CountArtistsQueryResponse : BaseResponse
{
    /// <summary>
    /// Properties
    /// </summary>
    public int ArtistsCount { get; set; }

    public CountArtistsQueryResponse() : base ()
    {

    }
}
