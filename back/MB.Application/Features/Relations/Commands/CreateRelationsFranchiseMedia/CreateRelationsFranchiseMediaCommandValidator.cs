using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsFranchiseMedia;

public class CreateRelationsFranchiseMediaCommandValidator : AbstractValidator<CreateRelationsFranchiseMediaCommand>
{
    public CreateRelationsFranchiseMediaCommandValidator()
    {
        RuleFor(request => request.FranchiseId)
            .NotEmpty().WithMessage("FranchiseId must not be empty.");

        RuleFor(request => request.MediaIds)
            .NotEmpty().WithMessage("Medias list must not be empty.")
            .Must(mediaIds => mediaIds.All(mediaId => mediaId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}