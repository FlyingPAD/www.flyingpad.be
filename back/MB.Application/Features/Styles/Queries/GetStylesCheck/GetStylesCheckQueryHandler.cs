using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesCheck;

public class GetStylesCheckQueryHandler(IStyleRepository styleRepository) : IRequestHandler<GetStylesCheckQuery, GetStylesCheckQueryResponse>
{
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<GetStylesCheckQueryResponse> Handle(GetStylesCheckQuery request, CancellationToken cancellationToken)
    {
        var styles = await _styleRepository.GetStylesWithCheck(request.ArtistId);

        return new GetStylesCheckQueryResponse
        {
            Success = true,
            StylesCheck = styles
        };
    }
}