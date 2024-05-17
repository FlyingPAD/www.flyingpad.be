using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesCheck;

public class GetStylesCheckQuery : IRequest<GetStylesCheckQueryResponse>
{
    public Guid ArtistId { get; set; }
}
