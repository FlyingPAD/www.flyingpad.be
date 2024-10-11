using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Queries.CountStyles;

public class CountStylesQueryHandler(IBaseRepository<Style> styleRepository) : IRequestHandler<CountStylesQuery, CountStylesQueryResponse>
{
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<CountStylesQueryResponse> Handle(CountStylesQuery request, CancellationToken cancellationToken)
    {
        var totalStyles = await _styleRepository.CountAsync();

        return new CountStylesQueryResponse
        {
            Success = true,
            Message = "Styles count completed.",
            TotalStyles = totalStyles
        };
    }
}