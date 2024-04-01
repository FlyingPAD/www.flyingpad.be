using FluentValidation;

namespace MB.Application.Features.Tags.Commands.UpdateTag
{
    public class UpdateTagCommandValidator : AbstractValidator<UpdateTagCommand>
    {
        public UpdateTagCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
