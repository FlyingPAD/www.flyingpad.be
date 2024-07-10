using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelById;

public class GetModelByIdQuery : IRequest<GetModelByIdQueryResponse>
{
    public Guid ModelId { get; set; }
}