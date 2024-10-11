using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQuery : IRequest<GetMoodsByFranchiseQueryResponse>
{
    public Guid FranchiseId { get; set; }
}