using FluentValidation;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommandValidator : AbstractValidator<DeleteMoodCommand>
{
    public DeleteMoodCommandValidator()
    {
        RuleFor(x => x.MoodId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
    }
}
