using FluentValidation;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodTags
{
    public class CreateRelationsMoodTagsCommandValidator : AbstractValidator<CreateRelationsMoodTagsCommand>
    {
        public CreateRelationsMoodTagsCommandValidator()
        {
            RuleFor(command => command.MoodId)
                .NotEmpty().WithMessage("Mood ID must not be empty.");

            RuleFor(command => command.TagIds)
                .NotEmpty().WithMessage("Tag list musn't be empty.")
                .Must(styleIds => styleIds.All(styleId => styleId != Guid.Empty))
                .WithMessage("One or more tag ID's are invalid.");
        }
    }
}
