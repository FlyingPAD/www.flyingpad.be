using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IModelRepository modelRepo) : IRequestHandler<GetModelCheckBoxesByMoodQuery, GetModelCheckBoxesByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
    private readonly IModelRepository _modelRepo = modelRepo;

    public async Task<GetModelCheckBoxesByMoodQueryResponse> Handle(GetModelCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
    {
        int moodId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var models = await _modelRepo.GetModelsCheckBoxesByMood(moodId);

        return new GetModelCheckBoxesByMoodQueryResponse
        {
            Success = true,
            Message = "Checkboxes / Models",
            Models = _mapper.Map<IEnumerable<GetModelCheckBoxesByMoodQueryDto>>(models)
        };
    }
}