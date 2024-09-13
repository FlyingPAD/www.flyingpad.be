using FluentValidation;

namespace MB.Application.Features.VideosYouTube.Queries.GetOneVideoYTDetails;

public class GetOneVideoYTDetailsQueryValidator : AbstractValidator<GetOneVideoYTDetailsQuery>
{
    public GetOneVideoYTDetailsQueryValidator()
    {
        RuleFor(request => request.VideoYouTubeId)
            .NotEmpty().WithMessage("VideoId is required.")
            .NotEqual(Guid.Empty).WithMessage("VideoId must not be empty.");
    }
}