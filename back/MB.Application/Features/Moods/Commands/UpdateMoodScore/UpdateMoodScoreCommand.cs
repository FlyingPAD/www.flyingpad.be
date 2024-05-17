using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodScore;

public class UpdateMoodScoreCommand : IRequest<UpdateMoodScoreCommandResponse>
{
    public Guid BusinessId { get; set; } = Guid.Empty;
    public int Value { get; set; } = 0;
}
