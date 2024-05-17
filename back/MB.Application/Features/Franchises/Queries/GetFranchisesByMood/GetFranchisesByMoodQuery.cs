using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQuery : IRequest<GetFranchisesByMoodQueryResponse>
{
    public Guid BusinessId { get; set; } = Guid.Empty;
}
