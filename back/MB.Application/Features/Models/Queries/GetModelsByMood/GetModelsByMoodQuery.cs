using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsByMood
{
    public class GetModelsByMoodQuery : IRequest<GetModelsByMoodQueryResponse>
    {
        public Guid MoodId { get; set; } = Guid.Empty;
    }
}