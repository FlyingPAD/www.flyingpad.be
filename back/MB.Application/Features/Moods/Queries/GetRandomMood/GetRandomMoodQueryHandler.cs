using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetRandomMood;

public class GetRandomMoodQueryHandler(IMapper mapper, IMoodRepository moodRepository) : IRequestHandler<GetRandomMoodQuery, GetRandomMoodQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IMoodRepository _moodRepository = moodRepository;

    public async Task<GetRandomMoodQueryResponse> Handle(GetRandomMoodQuery request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetOneDetailsRandom()
            ?? throw new NotFoundException("Mood not found.");

        return new GetRandomMoodQueryResponse
        {
            Success = true,
            Message = "A random mood was loaded.",
            Mood = _mapper.Map<GetRandomMoodQueryDto>(mood)
        };
    }
}