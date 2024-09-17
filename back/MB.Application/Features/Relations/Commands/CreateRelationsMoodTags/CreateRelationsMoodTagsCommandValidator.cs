using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommandValidator : AbstractValidator<CreateRelationsMoodTagsCommand>
{
    public CreateRelationsMoodTagsCommandValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId must not be empty.");

        RuleFor(request => request.TagIds)
            .NotEmpty().WithMessage("Tags list must not be empty.")
            .Must(tagIds => tagIds.All(tagId => tagId != Guid.Empty))
            .WithMessage("One or more invalid Id('s).");
    }
}