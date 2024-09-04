using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryHandler : IRequestHandler<GetMoodByIdQuery, GetMoodByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<Mood> _moodRepository;

    public GetMoodByIdQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepository)
    {
        _mapper = mapper;
        _moodRepository = moodRepository;
    }

    public async Task<GetMoodByIdQueryResponse> Handle(GetMoodByIdQuery request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetByBusinessIdAsync(request.Id);

        if (mood == null)
        {
            return new GetMoodByIdQueryResponse { Success = false, Message = "Mood wasn't found :(" };
        }

        var moodDto = _mapper.Map<GetMoodByIdVm>(mood);

        return new GetMoodByIdQueryResponse
        {
            Success = true,
            Message = "Mood was found :)",
            Mood = moodDto
        };
    }
}
