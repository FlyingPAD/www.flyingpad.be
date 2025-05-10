using FluentValidation;

namespace MB.Application.Features.Users.Commands.UnlockAchievement;

public class UnlockAchievementCommandValidator : AbstractValidator<UnlockAchievementCommand>
{
    public UnlockAchievementCommandValidator()
    {
        RuleFor(x => x.UserBusinessId)
            .NotEmpty().WithMessage("UserBusinessId is required.");

        RuleFor(x => x.AchievementBusinessId)
            .NotEmpty().WithMessage("AchievementBusinessId is required.");
    }
}