using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQuery : IRequest<GetTagByIdQueryResponse>
{
    public Guid TagId { get; set; }
}