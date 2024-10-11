using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQuery : IRequest<GetMoodsByTagQueryResponse>
{
    public Guid TagId { get; set; }
}