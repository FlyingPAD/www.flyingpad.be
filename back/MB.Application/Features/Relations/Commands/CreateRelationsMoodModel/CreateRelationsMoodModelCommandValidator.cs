using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodModel;

public class CreateRelationsMoodModelCommandValidator : AbstractValidator<CreateRelationsMoodModelCommand>
{
    public CreateRelationsMoodModelCommandValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId must not be Empty.");

        RuleFor(request => request.ModelIds)
            .NotEmpty().WithMessage("Models list must not be empty.")
            .Must(modelIds => modelIds.All(modelId => modelId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}
