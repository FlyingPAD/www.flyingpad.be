using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryHandler(IMapper mapper, IBaseRepository<Mood> moodRepository) : IRequestHandler<GetMoodByIdQuery, GetMoodByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<GetMoodByIdQueryResponse> Handle(GetMoodByIdQuery request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        return new GetMoodByIdQueryResponse
        {
            Success = true,
            Message = "Mood was loaded.",
            Mood = _mapper.Map<GetMoodByIdQueryDto>(mood)
        };
    }
}