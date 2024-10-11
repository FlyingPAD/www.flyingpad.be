using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQuery : IRequest<GetMoodByIdQueryResponse>
{
    public Guid MoodId { get; set; }
}