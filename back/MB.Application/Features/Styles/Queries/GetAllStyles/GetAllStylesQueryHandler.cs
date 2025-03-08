using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Domain.StyleAggregate;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetAllStyles;

public class GetAllStylesQueryHandler(IBaseRepository<Style> styleRepository, IMapper mapper) : IRequestHandler<GetAllStylesQuery, GetAllStylesQueryResponse>
{
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllStylesQueryResponse> Handle(GetAllStylesQuery request, CancellationToken cancellationToken)
    {
        var styles = await _styleRepository.GetAllAsync(style => style.Name);

        return new GetAllStylesQueryResponse
        {
            Success = true,
            Message = "All styles.",
            Styles = _mapper.Map<List<GetAllStylesQueryDto>>(styles)
        };
    }
}