using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMood;

public class GetFranchisesByMoodQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepository, IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<GetFranchisesByMoodQuery, GetFranchisesByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<GetFranchisesByMoodQueryResponse> Handle(GetFranchisesByMoodQuery request, CancellationToken cancellationToken)
    {
        var moodId = await _moodRepository.GetEntityIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var models = await _modelRepository.GetModelsByMood(moodId);

        var modelIds = models.Select(model => model.EntityId).ToList();

        var franchises = await _franchiseRepository.GetFranchisesByModels(modelIds);

        return new GetFranchisesByMoodQueryResponse
        {
            Success = true,
            Message = "Franchises by mood.",
            FranchisesByMood = _mapper.Map<List<GetFranchisesByMoodQueryDto>>(franchises)
        };
    }
}