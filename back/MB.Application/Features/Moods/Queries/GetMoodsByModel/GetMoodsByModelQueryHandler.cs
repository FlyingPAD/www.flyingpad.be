using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel
{
    public class GetMoodsByModelQueryHandler(IMapper mapper, IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<GetMoodsByModelQuery, GetMoodsByModelQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IMoodRepository _moodRepository = moodRepository;
        private readonly IModelRepository _modelRepository = modelRepository;

        public async Task<GetMoodsByModelQueryResponse> Handle(GetMoodsByModelQuery request, CancellationToken cancellationToken)
        {
            int? modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId);

            var moods = await _moodRepository.GetMoodsByModel(modelId);

            var response = new GetMoodsByModelQueryResponse
            {
                Success = true,
                Message = "Moods By Model",
                Moods = _mapper.Map<List<GetMoodsByModelQueryVm>>(moods)
            };

            return response;
        }
    }
}