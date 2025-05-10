using FluentValidation;

namespace MB.Application.Features.Users.Commands.GainExperience;

public class GainExperienceCommandValidator : AbstractValidator<GainExperienceCommand>
{
    public GainExperienceCommandValidator()
    {
        RuleFor(x => x.UserBusinessId)
            .NotEmpty().WithMessage("UserBusinessId is required.");

        RuleFor(x => x.Xp)
            .GreaterThan(0).WithMessage("Xp must be greater than zero.");
    }
}