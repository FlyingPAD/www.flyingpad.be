using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.ApproveMoods;

public class ApproveMoodsCommandHandler(IMoodRepository _moodRepo) : IRequestHandler<ApproveMoodsCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepo = _moodRepo;
    public async Task<BaseResponse> Handle(ApproveMoodsCommand command, CancellationToken cancellationToken)
    {
        var moods = await _moodRepo.GetByBusinessIdsAsync(command.MoodIds, cancellationToken) ?? throw new NotFoundException("Moods not found");

        foreach (var mood in moods)
        {
            mood.Approve();
        }

        await _moodRepo.SaveChangesAsync(cancellationToken);

        return new BaseResponse
        {
            Success = true,
            Message = "Moods approved successfully"
        };
    }
}