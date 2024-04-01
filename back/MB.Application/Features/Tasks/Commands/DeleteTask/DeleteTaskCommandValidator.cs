using FluentValidation;

namespace MB.Application.Features.Tasks.Commands.DeleteTask
{
    public class DeleteTaskCommandValidator : AbstractValidator<DeleteTaskCommand>
    {
        public DeleteTaskCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
