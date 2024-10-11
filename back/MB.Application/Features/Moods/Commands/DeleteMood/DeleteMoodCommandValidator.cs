using FluentValidation;

namespace MB.Application.Features.Moods.Commands.DeleteMood;

public class DeleteMoodCommandValidator : AbstractValidator<DeleteMoodCommand>
{
    public DeleteMoodCommandValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}