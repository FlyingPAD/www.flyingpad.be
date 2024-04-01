using FluentValidation;

namespace MB.Application.Features.Models.Queries.GetModelsByMood
{
    public class GetModelsByMoodQueryValidator : AbstractValidator<GetModelsByMoodQuery>
    {
        public GetModelsByMoodQueryValidator()
        {
            RuleFor(x => x.MoodId)
            .NotEmpty().WithMessage("ID is required.")
            .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}