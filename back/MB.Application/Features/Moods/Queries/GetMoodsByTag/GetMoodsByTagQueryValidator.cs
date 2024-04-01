using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag
{
    public class GetMoodsByTagQueryValidator : AbstractValidator<GetMoodsByTagQuery>
    {
        public GetMoodsByTagQueryValidator()
        {
            RuleFor(x => x.TagId)
                .NotEmpty().WithMessage("ID is required.")
                .NotEqual(Guid.Empty).WithMessage("ID must not be empty.");
        }
    }
}