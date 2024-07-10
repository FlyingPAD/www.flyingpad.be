using FluentValidation;

namespace MB.Application.Features.Models.Commands.UpdateModel;

public class UpdateModelCommandValidator : AbstractValidator<UpdateModelCommand>
{
    public UpdateModelCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is required.");
        RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is required.");
        RuleFor(x => x.Pseudonym).NotEmpty().WithMessage("Pseudonym is required.");
        RuleFor(x => x.Gender).NotEmpty().WithMessage("Gender is required.");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required.");
    }
}