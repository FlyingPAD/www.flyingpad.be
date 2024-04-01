using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByMood
{
    public class GetTagsByMoodQueryHandler : IRequestHandler<GetTagsByMoodQuery, GetTagsByMoodQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMoodRepository _moodRepository;
        private readonly ITagRepository _tagRepository;

        public GetTagsByMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository)
        {
            _mapper = mapper;
            _moodRepository = moodRepository;
            _tagRepository = tagRepository;
        }

        public async Task<GetTagsByMoodQueryResponse> Handle(GetTagsByMoodQuery request, CancellationToken cancellationToken)
        {
            int? moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);

            var tags = await _tagRepository.GetTagsByMood(moodId);

            var response = new GetTagsByMoodQueryResponse
            {
                Success = true,
                Message = "Tags By Mood",
                TagsByMood = _mapper.Map<List<GetTagsByMoodQueryVm>>(tags)
            };

            return response;
        }
    }
}