using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByArtist
{
    public class CheckRelationsArtistStyleByArtistQuery : IRequest<CheckRelationsArtistStyleByArtistQueryResponse>
    {
        public Guid ArtistId { get; set; }
    }
}