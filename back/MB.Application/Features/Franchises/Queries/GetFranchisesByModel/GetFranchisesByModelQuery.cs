using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByModel;

public class GetFranchisesByModelQuery : IRequest<GetFranchisesByModelQueryResponse>
{
    public Guid ModelId { get; set; }
}