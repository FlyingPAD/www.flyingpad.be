using MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;
using MB.Application.Interfaces.Persistence;
using MediatR;

public class GetCommonTagsByMoodsQueryHandler(IMoodRepository moodRepository) : IRequestHandler<GetCommonTagsByMoodsQuery, GetCommonTagsByMoodsQueryResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<GetCommonTagsByMoodsQueryResponse> Handle(GetCommonTagsByMoodsQuery request, CancellationToken cancellationToken)
    {
        var commonTags = await _moodRepository.GetCommonTagsByMoods(request.MoodIds);

        return new GetCommonTagsByMoodsQueryResponse 
        {
            Success = true,
            Message = "Common Tags",
            CommonTags = commonTags 
        };
    }
}