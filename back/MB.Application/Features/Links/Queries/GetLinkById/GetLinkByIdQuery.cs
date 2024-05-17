using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQuery : IRequest<GetLinkByIdQueryResponse>
{
    public Guid LinkId { get; set; }
}