using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class GetTagsCheckBoxesByMoodQuery : IRequest<GetTagsCheckBoxesByMoodQueryResponse>
{
    public Guid MoodId { get; set; }
}