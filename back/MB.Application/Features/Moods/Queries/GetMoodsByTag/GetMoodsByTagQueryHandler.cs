using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<GetMoodsByTagQuery, GetMoodsByTagQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetMoodsByTagQueryResponse> Handle(GetMoodsByTagQuery request, CancellationToken cancellationToken)
    {
        int tagId = await _tagRepository.GetPrimaryIdByBusinessIdAsync(request.TagId)
            ?? throw new NotFoundException("Tag not found.");

        var moods = await _moodRepository.GetMoodsByTag(tagId);

        return new GetMoodsByTagQueryResponse
        {
            Success = true,
            Message = "Moods by tag.",
            Moods = _mapper.Map<List<GetMoodsByTagQueryDto>>(moods)
        };
    }
}