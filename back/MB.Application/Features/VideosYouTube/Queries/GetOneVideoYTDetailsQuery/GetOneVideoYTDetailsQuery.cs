using MediatR;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetailsQuery
{
    public class GetOneVideoYTDetailsQuery : IRequest<GetOneVideoYTDetailsQueryResponse>
    {
        public Guid VideoYouTubeId { get; set; }
    }
}
