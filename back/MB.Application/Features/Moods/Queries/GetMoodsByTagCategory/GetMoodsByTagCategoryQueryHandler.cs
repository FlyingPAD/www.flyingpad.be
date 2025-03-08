using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTagCategory;

public class GetMoodsByTagCategoryQueryHandler(IMapper mapper, IMoodRepository moodRepository) : IRequestHandler<GetMoodsByTagCategoryQuery, GetMoodsByTagCategoryQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<GetMoodsByTagCategoryQueryResponse> Handle(GetMoodsByTagCategoryQuery request, CancellationToken cancellationToken)
    {
        var moods = await _moodRepository.GetMoodsByTagCategory(request.TagCategoryId);

        return new GetMoodsByTagCategoryQueryResponse
        {
            Success = true,
            Message = "Moods by tag category.",
            Moods = _mapper.Map<List<GetMoodsByTagCategoryQueryDto>>(moods)
        };
    }
}