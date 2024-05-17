using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsByFranchise;

public class GetModelsByFranchiseQuery : IRequest<GetModelsByFranchiseQueryResponse>
{
    public Guid FranchiseId { get; set; } = Guid.Empty;
}
