using AutoMapper;
using MB.Application.Exceptions;
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
        int moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var tags = await _tagRepository.GetTagsCheckBoxesByMood(moodId);

        var tagsDto = _mapper.Map<GetTagsCheckBoxesByMoodQueryDto[]>(tags);

        return new GetTagsCheckBoxesByMoodQueryResponse
        {
            Success = true,
            Message = "Related tags.",
            TagsCheckBoxesList = tagsDto
        };
    }
}