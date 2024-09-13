using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood;

public class GetTagsByMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<GetTagsByMoodQuery, GetTagsByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetTagsByMoodQueryResponse> Handle(GetTagsByMoodQuery request, CancellationToken cancellationToken)
    {
        int moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var tags = await _tagRepository.GetTagsByMood(moodId);

        return new GetTagsByMoodQueryResponse
        {
            Success = true,
            Message = "Success.",
            TagsByMood = _mapper.Map<List<GetTagsByMoodQueryDto>>(tags)
        };
    }
}