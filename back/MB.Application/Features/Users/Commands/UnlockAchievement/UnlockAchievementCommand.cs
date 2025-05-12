using MediatR;
using MB.Application.Models;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public class UnlockAchievementCommand : IRequest<BaseResponse>
{
    public Guid UserBusinessId { get; init; }

    public string AchievementCode { get; init; } = string.Empty;
}