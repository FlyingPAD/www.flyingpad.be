using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsFranchiseMedia;

public class CreateRelationsFranchiseMediaCommandValidator : AbstractValidator<CreateRelationsFranchiseMediaCommand>
{
    public CreateRelationsFranchiseMediaCommandValidator()
    {
        RuleFor(command => command.FranchiseId)
            .NotEmpty().WithMessage("Franchise ID must not be empty.");

        RuleFor(command => command.MediaIds)
            .NotEmpty().WithMessage("List must not be empty.")
            .Must(mediaIds => mediaIds.All(mediaId => mediaId != Guid.Empty))
            .WithMessage("One or more invalid ID(s).");
    }
}