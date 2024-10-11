using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQuery : IRequest<GetFranchisesByMoodQueryResponse>
{
    public Guid MoodId { get; set; }
}