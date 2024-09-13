using MediatR;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;

public class GetOneVideoYTDetailsQuery : IRequest<GetOneVideoYTDetailsQueryResponse>
{
    public Guid VideoYouTubeId { get; set; }
}
