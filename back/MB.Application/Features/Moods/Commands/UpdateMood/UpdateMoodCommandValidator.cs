using FluentValidation;

namespace MB.Application.Features.Moods.Commands.UpdateMood;

public class UpdateMoodCommandValidator : AbstractValidator<UpdateMoodCommand>
{
    public UpdateMoodCommandValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage("Name is required.");
        RuleFor(request => request.Description).NotEmpty().WithMessage("Description is required.");
    }
}