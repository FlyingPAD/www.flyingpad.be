using FluentValidation;

namespace MB.Application.Features.Medias.Commands.CreateMedia
{
    public class CreateMediaCommandValidator : AbstractValidator<CreateMediaCommand>
    {
        public CreateMediaCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
