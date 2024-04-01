using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesCheck
{
    public class GetStylesCheckQueryHandler : IRequestHandler<GetStylesCheckQuery, GetStylesCheckQueryResponse>
    {
        private readonly GetStylesCheckQueryValidator _validator;
        private readonly IStyleRepository _styleRepository;

        public GetStylesCheckQueryHandler(GetStylesCheckQueryValidator validator, IStyleRepository styleRepository)
        {
            _validator = validator;
            _styleRepository = styleRepository;
        }

        public async Task<GetStylesCheckQueryResponse> Handle(GetStylesCheckQuery request, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (validationResult.Errors.Count > 0)
            {
                return new GetStylesCheckQueryResponse
                {
                    Message = "Validation errors occurred",
                    ValidationErrors = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                };
            }

            var styles = await _styleRepository.GetStylesWithCheck(request.ArtistId);

            return new GetStylesCheckQueryResponse
            {
                Success = true,
                StylesCheck = styles
            };
        }
    }
}
