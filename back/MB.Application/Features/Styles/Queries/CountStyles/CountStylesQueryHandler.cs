using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Queries.CountStyles;

public class CountStylesQueryHandler : IRequestHandler<CountStylesQuery, CountStylesQueryResponse>
{
    private readonly IBaseRepository<Style> _styleRepository;

    public CountStylesQueryHandler(IBaseRepository<Style> styleRepository)
    {
        _styleRepository = styleRepository;
    }

    public async Task<CountStylesQueryResponse> Handle(CountStylesQuery request, CancellationToken cancellationToken)
    {
        var stylesCount = await _styleRepository.CountAsync();

        return new CountStylesQueryResponse
        {
            Success = true,
            Message = $"Total Styles : {stylesCount}",
            StylesCount = stylesCount
        };
    }
}
