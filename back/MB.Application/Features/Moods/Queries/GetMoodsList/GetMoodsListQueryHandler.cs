using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsList
{
    public class GetMoodsListQueryHandler : IRequestHandler<GetMoodsListQuery, GetMoodsListQueryResponse>
    {
        private readonly IBaseRepository<Mood> _moodRepository;
        private readonly IMapper _mapper;

        public GetMoodsListQueryHandler(IBaseRepository<Mood> moodRepository, IMapper mapper)
        {
            _moodRepository = moodRepository;
            _mapper = mapper;
        }

        public async Task<GetMoodsListQueryResponse> Handle(GetMoodsListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var moods = await _moodRepository.GetAllAsync(mood => mood.Score, false);

                var response = new GetMoodsListQueryResponse
                {
                    Success = true,
                    Message = "Here are the Moods !",
                    MoodsList = _mapper.Map<List<MoodListVm>>(moods)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetMoodsListQueryResponse
                {
                    Success = false,
                    ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
                };

                return response;
            }
        }
    }
}
