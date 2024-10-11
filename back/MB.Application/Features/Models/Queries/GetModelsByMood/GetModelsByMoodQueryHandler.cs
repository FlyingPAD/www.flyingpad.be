using AutoMapper;
using MB.Application.Exceptions;
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
        int moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var models = await _modelRepo.GetModelsByMood(moodId);

        return new GetModelsByMoodQueryResponse
        {
            Success = true,
            Message = "Models by mood.",
            Models = _mapper.Map<List<GetModelsByMoodQueryDto>>(models)
        };
    }
}