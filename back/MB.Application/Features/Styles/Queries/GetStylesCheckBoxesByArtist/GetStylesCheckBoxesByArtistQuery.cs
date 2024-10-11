using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesCheckBoxesByArtist;

public class GetStylesCheckBoxesByArtistQuery : IRequest<GetStylesCheckBoxesByArtistQueryResponse>
{
    public Guid ArtistId { get; set; }
}