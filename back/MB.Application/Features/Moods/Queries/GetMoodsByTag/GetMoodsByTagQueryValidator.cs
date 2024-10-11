using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodsByTag;

public class GetMoodsByTagQueryValidator : AbstractValidator<GetMoodsByTagQuery>
{
    public GetMoodsByTagQueryValidator()
    {
        RuleFor(request => request.TagId)
            .NotEmpty().WithMessage("TagId is required.")
            .NotEqual(Guid.Empty).WithMessage("TagId must not be empty.");
    }
}