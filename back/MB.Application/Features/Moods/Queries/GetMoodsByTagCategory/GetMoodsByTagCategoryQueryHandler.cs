using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;

public class GetMoodsByTagCategoryQueryHandler(IMoodRepository moodRepository): IRequestHandler<GetMoodsByTagCategoryQuery, GetMoodsByTagCategoryQueryResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<GetMoodsByTagCategoryQueryResponse> Handle(GetMoodsByTagCategoryQuery request, CancellationToken cancellationToken)
    {
        var moods = await _moodRepository.GetMoodsByTagCategory(request.TagCategoryId);
        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetMoodsByTagCategoryQueryResponse
        {
            Success = true,
            Message = "Moods by tag category.",
            Moods = dtos
        };
    }
}