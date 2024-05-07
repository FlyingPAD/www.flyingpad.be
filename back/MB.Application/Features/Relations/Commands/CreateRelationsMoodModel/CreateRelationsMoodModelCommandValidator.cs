using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel
{
    public class CreateRelationsMoodModelCommandValidator : AbstractValidator<CreateRelationsMoodModelCommand>
    {
        public CreateRelationsMoodModelCommandValidator()
        {
            RuleFor(command => command.MoodId)
                .NotEmpty().WithMessage("Mood ID must not be Empty.");

            RuleFor(command => command.ModelIds)
                .NotEmpty().WithMessage("Model ID's must not be Empty.")
                .Must(modelIds => modelIds.All(modelId => modelId != Guid.Empty))
                .WithMessage("One or more invalid ID's.");
        }
    }
}
