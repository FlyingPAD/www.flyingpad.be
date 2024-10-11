using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQuery : IRequest<GetMoodsByModelQueryResponse>
{
    public Guid ModelId { get; set; }
}