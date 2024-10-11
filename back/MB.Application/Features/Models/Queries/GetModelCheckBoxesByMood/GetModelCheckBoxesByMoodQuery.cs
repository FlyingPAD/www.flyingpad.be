using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQuery : IRequest<GetModelCheckBoxesByMoodQueryResponse>
{
    public Guid MoodId { get; set; }
}