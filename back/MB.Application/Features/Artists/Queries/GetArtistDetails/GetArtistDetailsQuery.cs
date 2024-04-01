using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistDetails
{
    public class GetArtistDetailsQuery : IRequest<GetArtistDetailsQueryResponse>
    {
        public Guid ArtistId { get; set; }
    }
}

