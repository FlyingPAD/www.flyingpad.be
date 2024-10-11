using FluentValidation;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommandValidator : AbstractValidator<UpdateModelCommand>
{
    public UpdateModelCommandValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId is required.")
            .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");

        RuleFor(request => request.FirstName)
            .NotEmpty().WithMessage("First Name is required.");

        RuleFor(request => request.LastName)
            .NotEmpty().WithMessage("Last Name is required.");

        RuleFor(request => request.Pseudonym)
            .NotEmpty().WithMessage("Pseudonym is required.");

        RuleFor(request => request.Gender)
            .NotEmpty().WithMessage("Gender is required.");

        RuleFor(request => request.Description)
            .NotEmpty().WithMessage("Description is required.");
    }
}