using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelsByMood;

public class GetModelsByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IModelRepository modelRepo) : IRequestHandler<GetModelsByMoodQuery, GetModelsByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
    private readonly IModelRepository _modelRepo = modelRepo;

    public async Task<GetModelsByMoodQueryResponse> Handle(GetModelsByMoodQuery request, CancellationToken cancellationToken)
    {
        int? moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId);

        var models = await _modelRepo.GetModelsByMood(moodId);

        var response = new GetModelsByMoodQueryResponse
        {
            Success = true,
            Message = "Models By Mood",
            Models = _mapper.Map<List<GetModelsByMoodQueryVm>>(models)
        };

        return response;
    }
}