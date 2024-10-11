using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetMoodById;

public class GetMoodByIdQueryValidator : AbstractValidator<GetMoodByIdQuery>
{
    public GetMoodByIdQueryValidator()
    {
        RuleFor(request => request.MoodId)
            .NotEmpty().WithMessage("MoodId is required.")
            .NotEqual(Guid.Empty).WithMessage("MoodId must not be empty.");
    }
}