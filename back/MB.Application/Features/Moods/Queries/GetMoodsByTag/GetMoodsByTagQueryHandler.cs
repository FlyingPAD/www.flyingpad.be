using MB.Application.Exceptions;
using MB.Application.Features.Moods.Mapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryHandler(IMoodRepository moodRepository, ITagRepository tagRepository): IRequestHandler<GetMoodsByTagQuery, GetMoodsByTagQueryResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetMoodsByTagQueryResponse> Handle(GetMoodsByTagQuery request, CancellationToken cancellationToken)
    {
        var tagId = await _tagRepository.GetPrimaryIdByBusinessIdAsync(request.TagId)
            ?? throw new NotFoundException("Tag not found.");

        var moods = await _moodRepository.GetMoodsByTag(tagId);
        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetMoodsByTagQueryResponse
        {
            Success = true,
            Message = "Moods by tag.",
            Moods = dtos
        };
    }
}