using FluentValidation;

namespace MB.Application.Features.Moods.Queries.GetCommonTagsByMoods;

public class GetCommonTagsByMoodsQueryValidator : AbstractValidator<GetCommonTagsByMoodsQuery>
{
    public GetCommonTagsByMoodsQueryValidator()
    {
        RuleFor(request => request.MoodIds)
            .NotNull().WithMessage("MoodIds cannot be null.")
            .NotEmpty().WithMessage("MoodIds must not be empty.");
    }
}