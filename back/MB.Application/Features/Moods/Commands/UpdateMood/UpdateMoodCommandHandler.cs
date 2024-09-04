using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMood;

public class UpdateMoodCommandHandler(IMapper mapper, IBaseRepository<Mood> moodRepository) : IRequestHandler<UpdateMoodCommand, UpdateMoodCommandResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<UpdateMoodCommandResponse> Handle(UpdateMoodCommand request, CancellationToken cancellationToken)
    {
        var mood = await _moodRepository.GetByBusinessIdAsync(request.MoodId);

        if (mood == null)
        {
            return new UpdateMoodCommandResponse { Success = false, Message = "Mood was not found." };
        }

        _mapper.Map(request, mood);

        await _moodRepository.UpdateAsync(mood);

        var updatedMoodDto = _mapper.Map<UpdateMoodDto>(mood);

        return new UpdateMoodCommandResponse
        {
            Success = true,
            Message = "Mood was successfully updated.",
            UpdatedMood = updatedMoodDto
        };
    }
}
