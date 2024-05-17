using MediatR;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommand : IRequest<CreateMoodCommandResponse>
{
    public string Name { get; set; } = string.Empty;
}
