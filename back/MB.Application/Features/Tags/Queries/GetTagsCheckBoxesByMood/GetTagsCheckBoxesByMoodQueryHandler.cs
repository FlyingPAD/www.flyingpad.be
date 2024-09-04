using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood;

public class GetTagsCheckBoxesByMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<GetTagsCheckBoxesByMoodQuery, GetTagsCheckBoxesByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetTagsCheckBoxesByMoodQueryResponse> Handle(GetTagsCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
    {
        int? moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);

        var tags = await _tagRepository.GetTagsCheckBoxesByMood(moodId);

        var tagsDto = _mapper.Map<GetTagsCheckBoxesListDto[]>(tags);

        var response = new GetTagsCheckBoxesByMoodQueryResponse
        {
            Success = true,
            Message = "Tags CheckBoxes By Mood fetched successfully",
            TagsCheckBoxesList = tagsDto
        };

        return response;
    }
}