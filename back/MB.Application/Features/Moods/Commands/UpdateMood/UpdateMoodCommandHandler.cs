using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.MoodAggregate;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMood;

public class UpdateMoodCommandHandler(IMapper mapper, IBaseRepository<Mood> moodRepository) : IRequestHandler<UpdateMoodCommand, BaseResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<BaseResponse> Handle(UpdateMoodCommand request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        _mapper.Map(request, mood);

        await _moodRepository.UpdateAsync(mood);

        return new BaseResponse
        {
            Success = true,
            Message = "Mood update successful.",
        };
    }
}