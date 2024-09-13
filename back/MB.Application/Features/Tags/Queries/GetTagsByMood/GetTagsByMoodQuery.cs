using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood;

public class GetTagsByMoodQuery : IRequest<GetTagsByMoodQueryResponse>
{
    public Guid MoodId { get; set; }
}