using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistQuery : IRequest<GetArtistQueryResponse>
    {
        public Guid ArtistId { get; set; }
    }
}

