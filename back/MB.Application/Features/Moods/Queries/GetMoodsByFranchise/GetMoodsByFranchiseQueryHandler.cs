using MB.Application.Exceptions;
using MB.Application.Features.Moods.Mapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQueryHandler(IModelRepository modelRepository, IMoodRepository moodRepository, IFranchiseRepository franchiseRepository): IRequestHandler<GetMoodsByFranchiseQuery, GetMoodsByFranchiseQueryResponse>
{
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<GetMoodsByFranchiseQueryResponse> Handle(GetMoodsByFranchiseQuery request, CancellationToken cancellationToken)
    {
        var franchiseId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        var models = await _modelRepository.GetModelsByFranchise(franchiseId);
        var modelIds = models.Select(m => m.EntityId).ToList();
        var moods = await _moodRepository.GetMoodsByModels(modelIds);
        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetMoodsByFranchiseQueryResponse
        {
            Success = true,
            Message = "Moods by franchise.",
            Moods = dtos
        };
    }
}