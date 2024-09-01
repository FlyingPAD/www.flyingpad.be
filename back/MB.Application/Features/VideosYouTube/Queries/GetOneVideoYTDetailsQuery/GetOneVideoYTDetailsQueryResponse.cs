using MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery;
using MB.Application.Models;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetailsQuery;

public class GetOneVideoYTDetailsQueryResponse : BaseResponse
{
    public GetOneVideoYTDetailsQueryVm VideoYouTube { get; set; } = new GetOneVideoYTDetailsQueryVm();
}
