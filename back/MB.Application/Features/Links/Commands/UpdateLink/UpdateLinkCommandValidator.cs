using FluentValidation;

namespace MB.Application.Features.Links.Commands.UpdateLink
{
    public class UpdateLinkCommandValidator : AbstractValidator<UpdateLinkCommand>
    {
        public UpdateLinkCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
