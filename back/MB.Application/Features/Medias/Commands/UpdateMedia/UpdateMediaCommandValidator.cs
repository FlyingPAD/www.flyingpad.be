using FluentValidation;

namespace MB.Application.Features.Medias.Commands.UpdateMedia
{
    public class UpdateMediaCommandValidator : AbstractValidator<UpdateMediaCommand>
    {
        public UpdateMediaCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
