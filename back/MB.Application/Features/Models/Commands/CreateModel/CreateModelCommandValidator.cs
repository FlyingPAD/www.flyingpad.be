using FluentValidation;

namespace MB.Application.Features.Models.Commands.CreateModel;

public class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
{
    public CreateModelCommandValidator()
    {
        RuleFor(request => request.FirstName)
            .NotEmpty().WithMessage("FirstName is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("FirstName must not exceed 50 characters.");

        RuleFor(request => request.LastName)
            .NotEmpty().WithMessage("LastName is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("LastName must not exceed 50 characters.");
    }
}