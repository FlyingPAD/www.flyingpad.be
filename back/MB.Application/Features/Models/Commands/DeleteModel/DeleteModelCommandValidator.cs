using FluentValidation;

namespace MB.Application.Features.Models.Commands.DeleteModel
{
    public class DeleteModelCommandValidator : AbstractValidator<DeleteModelCommand>
    {
        public DeleteModelCommandValidator()
        {
            RuleFor(x => x.ModelId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
