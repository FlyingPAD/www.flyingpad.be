using MediatR;

namespace MB.Application.Features.Artists.Queries.GetArtistsByStyle;

public class GetArtistsByStyleQuery : IRequest<GetArtistsByStyleQueryResponse>
{
    public Guid StyleId { get; set; }
}