using FluentValidation;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public class UnlockAchievementCommandValidator : AbstractValidator<UnlockAchievementCommand>
{
    public UnlockAchievementCommandValidator()
    {
        RuleFor(x => x.UserBusinessId)
            .NotEmpty().WithMessage("UserBusinessId is required.");

        RuleFor(x => x.AchievementCode)
            .NotEmpty().WithMessage("AchievementCode is required.");
    }
}