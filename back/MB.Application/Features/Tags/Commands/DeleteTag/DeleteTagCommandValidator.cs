using FluentValidation;

namespace MB.Application.Features.Tags.Commands.DeleteTag
{
    public class DeleteTagCommandValidator : AbstractValidator<DeleteTagCommand>
    {
        public DeleteTagCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}
