using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.LinkAggregate;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinkById;

public class GetLinkByIdQueryHandler(IMapper mapper, IBaseRepository<Link> linkRepository) : IRequestHandler<GetLinkByIdQuery, GetLinkByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<GetLinkByIdQueryResponse> Handle(GetLinkByIdQuery request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetByBusinessIdAsync(request.LinkId)
            ?? throw new NotFoundException("Link not found.");

        return new GetLinkByIdQueryResponse
        {
            Success = true,
            Message = $"{link.Name}.",
            Link = _mapper.Map<GetLinkByIdQueryDto>(link)
        };
    }
}