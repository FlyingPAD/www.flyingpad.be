using FluentValidation;

namespace MB.Application.Features.Moods.Commands.MultiTags;

public class MultiTagsCommandValidator : AbstractValidator<MultiTagsCommand>
{
    public MultiTagsCommandValidator()
    {
        RuleFor(request => request.MoodIds)
            .NotEmpty().WithMessage("MoodIds cannot be empty.")
            .Must(moodIds => moodIds.All(id => id != Guid.Empty))
            .WithMessage("MoodIds must be valid.");

        RuleFor(request => request.TagsToAdd)
            .Must(tagIds => tagIds.All(id => id != Guid.Empty))
            .WithMessage("TagsToAdd must be valid.");

        RuleFor(request => request.TagsToRemove)
            .Must(tagIds => tagIds.All(id => id != Guid.Empty))
            .WithMessage("TagsToRemove must be valid.");
    }
}