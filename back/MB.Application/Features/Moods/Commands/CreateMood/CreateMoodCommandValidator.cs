using FluentValidation;

namespace MB.Application.Features.Moods.Commands.CreateMood;

public class CreateMoodCommandValidator : AbstractValidator<CreateMoodCommand>
{
    public CreateMoodCommandValidator()
    {
        RuleFor(request => request.Name)
            .NotEmpty().WithMessage("Name is required.")
            .NotNull()
            .MaximumLength(30).WithMessage("Name must not exceed 30 characters.");
    }
}