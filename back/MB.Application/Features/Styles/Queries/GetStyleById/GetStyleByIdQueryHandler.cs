using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.StyleAggregate;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStyleById;

public class GetStyleByIdQueryHandler(IMapper mapper, IBaseRepository<Style> styleRepository) : IRequestHandler<GetStyleByIdQuery, GetStyleByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<GetStyleByIdQueryResponse> Handle(GetStyleByIdQuery request, CancellationToken cancellationToken)
    {
        var style = await _styleRepository.GetByBusinessIdAsync(request.StyleId)
            ?? throw new NotFoundException("Style not found.");

        return new GetStyleByIdQueryResponse
        {
            Success = true,
            Message = $"{style.Name}.",
            Style = _mapper.Map<GetStyleByIdQueryDto>(style)
        };
    }
}