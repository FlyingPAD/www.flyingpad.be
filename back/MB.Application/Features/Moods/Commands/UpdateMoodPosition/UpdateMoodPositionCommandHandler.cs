using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodPosition;

public class UpdateMoodPositionCommandHandler(IMoodRepository _moodRepo) : IRequestHandler<UpdateMoodPositionCommand, BaseResponse>
{
    private readonly IMoodRepository moodRepo = _moodRepo;

    public async Task<BaseResponse> Handle(UpdateMoodPositionCommand command, CancellationToken cancellationToken)
    {
        var moods = await moodRepo.GetByBusinessIdsAsync(command.MoodIds, cancellationToken) ?? throw new NotFoundException("Moods not found");


        foreach (var mood in moods)
        {
            mood.UpdatePosition(command.Position);
        }

        await moodRepo.SaveChangesAsync(cancellationToken);

        return new BaseResponse
        {
            Success = true,
            Message = "Position was updated"
        };
    }
}