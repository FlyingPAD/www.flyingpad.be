using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.CountArtists;

public class CountArtistsQueryResponse : BaseResponse
{
    public int TotalArtists { get; set; }
}