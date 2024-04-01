using MB.Application.Responses;
using MediatR;

namespace MB.Application.Features.Relations.Queries.CheckRelationsArtistStyleByStyle
{
    public class CheckRelationsArtistStyleByStyleQuery : IRequest<CheckRelationsArtistStyleByStyleQueryResponse>
    {
        public Guid StyleId { get; set; }
    }
}