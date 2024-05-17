using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.CountLinks;

public class CountLinksQueryHandler : IRequestHandler<CountLinksQuery, CountLinksQueryResponse>
{
    private readonly IBaseRepository<Link> _linkRepository;

    public CountLinksQueryHandler(IBaseRepository<Link> linkRepository)
    {
        _linkRepository = linkRepository;
    }

    public async Task<CountLinksQueryResponse> Handle(CountLinksQuery request, CancellationToken cancellationToken)
    {
        var linksCount = await _linkRepository.CountAsync();

        return new CountLinksQueryResponse
        {
            Success = true,
            Message = $"Total Links : {linksCount}",
            LinksCount = linksCount
        };
    }
}