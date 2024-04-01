using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood
{
    public class GetFranchisesByMoodQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepository, IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<GetFranchisesByMoodQuery, GetFranchisesByMoodQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
        private readonly IMoodRepository _moodRepository = moodRepository;
        private readonly IModelRepository _modelRepository = modelRepository;

        public async Task<GetFranchisesByMoodQueryResponse> Handle(GetFranchisesByMoodQuery request, CancellationToken cancellationToken)
        {
            var moodEntityId = await _moodRepository.GetPrimaryIdByBusinessIdAsync(request.BusinessId);
            if (!moodEntityId.HasValue)
            {
                return new GetFranchisesByMoodQueryResponse
                {
                    Success = false,
                    Message = "Mood not found"
                };
            }

            var models = await _modelRepository.GetModelsByMood(moodEntityId.Value);
            var modelIds = models.Select(model => model.EntityId).ToList();
            var franchises = await _franchiseRepository.GetFranchisesByModels(modelIds);

            var response = new GetFranchisesByMoodQueryResponse
            {
                Success = true,
                Message = "Franchises retrieved successfully",
                FranchisesByMood = _mapper.Map<List<GetFranchisesByMoodQueryVm>>(franchises)
            };

            return response;
        }
    }
}
