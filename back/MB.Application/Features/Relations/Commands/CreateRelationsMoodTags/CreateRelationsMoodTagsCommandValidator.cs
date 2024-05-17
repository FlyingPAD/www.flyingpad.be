using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags;

public class CreateRelationsMoodTagsCommandValidator : AbstractValidator<CreateRelationsMoodTagsCommand>
{
    public CreateRelationsMoodTagsCommandValidator()
    {
        RuleFor(command => command.MoodId)
            .NotEmpty().WithMessage("Mood ID must not be empty.");

        RuleFor(command => command.TagIds)
            .NotEmpty().WithMessage("List must not be empty.")
            .Must(tagIds => tagIds.All(tagId => tagId != Guid.Empty))
            .WithMessage("One or more invalid ID(s).");
    }
}