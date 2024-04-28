using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsCheckBoxesByMood
{
    public class GetTagsCheckBoxesByMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository, ITagRepository tagRepository) : IRequestHandler<GetTagsCheckBoxesByMoodQuery, GetTagsCheckBoxesByMoodQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IMoodRepository _moodRepository = moodRepository;
        private readonly ITagRepository _tagRepository = tagRepository;

        public async Task<GetTagsCheckBoxesByMoodQueryResponse> Handle(GetTagsCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
        {
            int? moodId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.MoodId);

            var tags = await _tagRepository.GetTagsCheckBoxesByMood(moodId);

            // Mapper les données des tags au DTO de la réponse
            var tagsDto = _mapper.Map<GetTagsCheckBoxesListDto[]>(tags);

            // Construire la réponse
            var response = new GetTagsCheckBoxesByMoodQueryResponse
            {
                Success = true,
                Message = "Tags CheckBoxes By Mood fetched successfully",
                TagsCheckBoxesList = tagsDto
            };

            return response;
        }
    }
}