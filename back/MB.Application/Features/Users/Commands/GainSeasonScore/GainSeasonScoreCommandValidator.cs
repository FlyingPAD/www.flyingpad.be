using FluentValidation;

namespace MB.Application.Features.Users.Commands.GainSeasonScore;

public class GainSeasonScoreCommandValidator : AbstractValidator<GainSeasonScoreCommand>
{
    public GainSeasonScoreCommandValidator()
    {
        RuleFor(x => x.UserBusinessId)
            .NotEmpty()
            .WithMessage("UserBusinessId est requis.");
    }
}