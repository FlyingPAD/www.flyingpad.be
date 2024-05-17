using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetRandomMoodQuery;

public class GetRandomMoodQueryHandler : IRequestHandler<GetRandomMoodQuery, GetRandomMoodQueryResponse>
{
    private readonly IMapper _mapper;
    private IMoodRepository _moodRepository;

    public GetRandomMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository)
    {
        _mapper = mapper;
        _moodRepository = moodRepository;
    }

    public async Task<GetRandomMoodQueryResponse> Handle(GetRandomMoodQuery request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetOneDetailsRandom();

        if (mood == null)
        {
            return new GetRandomMoodQueryResponse { Success = false, Message = "Mood wasn't found :(" };
        }

        var moodVm = _mapper.Map<GetRandomMoodQueryVm>(mood);

        return new GetRandomMoodQueryResponse
        {
            Success = true,
            Message = "Mood was found :)",
            Mood = moodVm
        };
    }
}