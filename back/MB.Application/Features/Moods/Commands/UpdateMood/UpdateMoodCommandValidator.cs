using FluentValidation;

namespace MB.Application.Features.Moods.Commands.UpdateMood
{
    public class UpdateMoodCommandValidator : AbstractValidator<UpdateMoodCommand>
    {
        public UpdateMoodCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required.");
        }
    }
}