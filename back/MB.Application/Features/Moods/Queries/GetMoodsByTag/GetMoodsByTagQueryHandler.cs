using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<GetMoodsByTagQuery, GetMoodsByTagQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetMoodsByTagQueryResponse> Handle(GetMoodsByTagQuery request, CancellationToken cancellationToken)
    {
        int? tagId = await _tagRepository.GetPrimaryIdByBusinessIdAsync(request.TagId);

        var moods = await _moodRepository.GetMoodsByTag(tagId);

        var response = new GetMoodsByTagQueryResponse
        {
            Success = true,
            Message = "Moods By Tag",
            Moods = _mapper.Map<List<GetMoodsByTagQueryVm>>(moods)
        };

        return response;
    }
}