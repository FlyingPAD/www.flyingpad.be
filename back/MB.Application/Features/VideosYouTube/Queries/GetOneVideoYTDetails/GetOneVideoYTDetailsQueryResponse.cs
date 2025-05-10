using MB.Application.Models;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;

public class GetOneVideoYTDetailsQueryResponse : BaseResponse
{
    public GetOneVideoYTDetailsQueryDto VideoYouTube { get; set; } = new();
}