using MediatR;

namespace MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;

public class GetCommonTagsByMoodsQuery : IRequest<GetCommonTagsByMoodsQueryResponse>
{
    public Guid[] MoodIds { get; set; } = [];
}