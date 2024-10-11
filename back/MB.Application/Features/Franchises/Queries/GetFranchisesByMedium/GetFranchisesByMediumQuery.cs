using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;

public class GetFranchisesByMediumQuery : IRequest<GetFranchisesByMediumQueryResponse>
{
    public Guid MediumId { get; set; }
}