using FluentValidation;

namespace MB.Application.Features.Moods.Commands.MultiTags;

public class MultiTagsCommandValidator : AbstractValidator<MultiTagsCommand>
{
    public MultiTagsCommandValidator()
    {
        RuleFor(request => request.MoodIds)
            .NotEmpty().WithMessage("The mood list cannot be empty.")
            .Must(moodIds => moodIds.All(id => id != Guid.Empty))
            .WithMessage("All MoodIds must be valid.");

        RuleFor(request => request.Tags)
            .NotEmpty().WithMessage("The tag list cannot be empty.")
            .Must(tagIds => tagIds.All(id => id != Guid.Empty))
            .WithMessage("All TagIds must be valid.");
    }
}