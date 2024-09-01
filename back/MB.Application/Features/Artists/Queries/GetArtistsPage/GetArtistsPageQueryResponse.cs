using MB.Application.Models;

namespace MB.Application.Features.Artists.Queries.GetArtistsPage;

public class GetArtistsPageQueryResponse : BaseResponse
{
    public List<GetArtistsPageVm> ArtistsPage { get; set; } = [];

    public int TotalItems { get; set; }
    public int ItemPosition { get; set; }
    public Guid? PreviousId { get; set; }
    public Guid? NextId { get; set; }

    public GetArtistsPageQueryResponse() : base()
    {

    }
}