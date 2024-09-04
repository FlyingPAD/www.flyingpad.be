using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Models.Queries.GetModelCheckBoxesByMood;

public class GetModelCheckBoxesByMoodQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepo, IModelRepository modelRepo) : IRequestHandler<GetModelCheckBoxesByMoodQuery, GetModelCheckBoxesByMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepo = moodRepo;
    private readonly IModelRepository _modelRepo = modelRepo;

    public async Task<GetModelCheckBoxesByMoodQueryResponse> Handle(GetModelCheckBoxesByMoodQuery request, CancellationToken cancellationToken)
    {
        int? moodEntityId = await _moodRepo.GetPrimaryIdByBusinessIdAsync(request.MoodId);

        if (!moodEntityId.HasValue)
        {
            return new GetModelCheckBoxesByMoodQueryResponse
            {
                Success = false,
                Message = "No mood found with the given ID"
            };
        }

        var models = await _modelRepo.GetModelsCheckBoxesByMood(moodEntityId.Value);

        var response = new GetModelCheckBoxesByMoodQueryResponse
        {
            Success = true,
            Message = "Models retrieved based on mood",
            Models = _mapper.Map<IEnumerable<GetModelCheckBoxesByMoodQueryDto>>(models)
        };

        return response;
    }
}