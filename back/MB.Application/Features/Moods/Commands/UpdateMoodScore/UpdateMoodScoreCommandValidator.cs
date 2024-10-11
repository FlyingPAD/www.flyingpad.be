using FluentValidation;

namespace MB.Application.Features.Moods.Commands.UpdateMoodScore;

public class UpdateMoodScoreCommandValidator : AbstractValidator<UpdateMoodScoreCommand>
{
    public UpdateMoodScoreCommandValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");

        RuleFor(request => request.Value)
            .InclusiveBetween(-50, 50).WithMessage("Value must be between -50 and 50.");
    }
}