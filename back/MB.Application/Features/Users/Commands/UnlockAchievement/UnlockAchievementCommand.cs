using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public record UnlockAchievementCommand(Guid UserBusinessId, Guid AchievementBusinessId) : IRequest<BaseResponse>;