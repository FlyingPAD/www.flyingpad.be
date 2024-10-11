using FluentValidation;

namespace MB.Application.Features.Medias.Queries.GetMediumById;

public class GetMediumByIdQueryValidator : AbstractValidator<GetMediumByIdQuery>
{
    public GetMediumByIdQueryValidator()
    {
        RuleFor(request => request.MediumId)
            .NotEmpty().WithMessage("MediumId is required.")
            .NotEqual(Guid.Empty).WithMessage("MediumId must not be empty.");
    }
}