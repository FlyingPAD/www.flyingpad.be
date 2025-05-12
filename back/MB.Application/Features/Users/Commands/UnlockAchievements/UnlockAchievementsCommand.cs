using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievements;

public class UnlockAchievementsCommand : IRequest<BaseResponse>
{
    public Guid UserBusinessId { get; init; }
    public IEnumerable<string> AchievementCodes { get; init; } = [];
}