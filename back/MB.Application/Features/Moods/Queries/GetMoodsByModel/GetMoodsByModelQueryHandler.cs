using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByModel;

public class GetMoodsByModelQueryHandler(IMapper mapper, IMoodRepository moodRepository, IModelRepository modelRepository) : IRequestHandler<GetMoodsByModelQuery, GetMoodsByModelQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IModelRepository _modelRepository = modelRepository;

    public async Task<GetMoodsByModelQueryResponse> Handle(GetMoodsByModelQuery request, CancellationToken cancellationToken)
    {
        int modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId)
            ?? throw new NotFoundException("Model not found.");

        var moods = await _moodRepository.GetMoodsByModel(modelId);

        return new GetMoodsByModelQueryResponse
        {
            Success = true,
            Message = "Moods by model.",
            Moods = _mapper.Map<List<GetMoodsByModelQueryDto>>(moods)
        };
    }
}