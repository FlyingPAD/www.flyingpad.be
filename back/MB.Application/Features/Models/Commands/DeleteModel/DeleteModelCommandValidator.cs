using FluentValidation;

namespace MB.Application.Features.Models.Commands.DeleteModel;

public class DeleteModelCommandValidator : AbstractValidator<DeleteModelCommand>
{
    public DeleteModelCommandValidator()
    {
        RuleFor(request => request.ModelId)
            .NotEmpty().WithMessage("ModelId is required.")
            .NotEqual(Guid.Empty).WithMessage("ModelId must not be empty.");
    }
}