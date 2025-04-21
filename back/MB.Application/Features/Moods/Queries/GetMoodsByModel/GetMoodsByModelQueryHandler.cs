using MB.Application.Exceptions;
using MB.Application.Features.Moods.Mapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryHandler(IMoodRepository moodRepository, IModelRepository modelRepository): IRequestHandler<GetMoodsByModelQuery, GetMoodsByModelQueryResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<GetMoodsByModelQueryResponse> Handle(GetMoodsByModelQuery request, CancellationToken cancellationToken)
    {
        var modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException("Model not found.");

        var moods = await _moodRepository.GetMoodsByModel(modelId);
        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetMoodsByModelQueryResponse
        {
            Success = true,
            Message = "Moods by model.",
            Moods = dtos
        };
    }
}