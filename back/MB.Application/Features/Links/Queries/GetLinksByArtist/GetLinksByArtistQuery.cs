using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByArtist
{
    public class GetLinksByArtistQuery : IRequest<GetLinksByArtistQueryResponse>
    {
        public Guid ArtistId { get; set; }
    }
}