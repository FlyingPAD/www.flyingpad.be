using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.CountLinks;

public class CountLinksQueryHandler(IBaseRepository<Link> linkRepository) : IRequestHandler<CountLinksQuery, CountLinksQueryResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<CountLinksQueryResponse> Handle(CountLinksQuery request, CancellationToken cancellationToken)
    {
        return new CountLinksQueryResponse
        {
            Success = true,
            Message = "Links count completed.",
            TotalLinks = await _linkRepository.CountAsync()
        };
    }
}