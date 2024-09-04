using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStylesList;

public class GetStylesListQueryHandler : IRequestHandler<GetStylesListQuery, GetStylesListQueryResponse>
{
    private readonly IBaseRepository<Style> _styleRepository;
    private readonly IMapper _mapper;

    public GetStylesListQueryHandler(IBaseRepository<Style> styleRepository, IMapper mapper)
    {
        _styleRepository = styleRepository;
        _mapper = mapper;
    }

    public async Task<GetStylesListQueryResponse> Handle(GetStylesListQuery request, CancellationToken cancellationToken)
    {
        var styles = await _styleRepository.GetAllAsync();
        var response = new GetStylesListQueryResponse
        {
            Success = true,
            Message = "Success !",
            Styles = _mapper.Map<List<StyleListVm>>(styles)
        };

        return response;
    }
}