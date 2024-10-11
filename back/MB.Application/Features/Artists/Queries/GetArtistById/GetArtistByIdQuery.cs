using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistById;

public class GetArtistByIdQuery : IRequest<GetArtistByIdQueryResponse>
{
    public Guid ArtistId { get; set; }
}