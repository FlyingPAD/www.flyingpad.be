using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommandHandler(IBaseRepository<Mood> moodRepository) : IRequestHandler<CreateMoodCommand, CreateMoodCommandResponse>
{
    private readonly IBaseRepository<Mood> _moodRepository = moodRepository;

    public async Task<CreateMoodCommandResponse> Handle(CreateMoodCommand request, CancellationToken cancellationToken)
    {
        var mood = new Mood()
        {
            Name = request.Name,
            Description = request.Description
        };

        mood = await _moodRepository.CreateAsync(mood);

        return new CreateMoodCommandResponse()
        {
            MoodId = mood.BusinessId,
            Success = true,
            Message = "Mood was created succesfully."
        };
    }
}