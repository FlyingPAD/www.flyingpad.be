using AutoMapper;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.LinkAggregate;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetPageLinksContainingAbc;

public class GetPageLinksContainingAbcQueryHandler : IRequestHandler<GetPageLinksContainingAbcQuery, GetPageLinksContainingAbcQueryResponse>
{
    private readonly IMapper _mapper;
    private readonly ILinkRepository _linkRepository;

    public GetPageLinksContainingAbcQueryHandler(IMapper mapper, ILinkRepository linkRepository)
    {
        _mapper = mapper;
        _linkRepository = linkRepository;
    }

    public async Task<GetPageLinksContainingAbcQueryResponse> Handle(GetPageLinksContainingAbcQuery request, CancellationToken cancellationToken)
    {
        IEnumerable<Link> linksContainingAbc;

        int entityId = 0;

        // Chercher l'ID entier (EntityId) correspondant à partir de l'identifiant métier (BusinessId) reçu du front-end.
        if (request.StartId != Guid.Empty)
        {
            var linkWithBusinessId = await _linkRepository.GetByBusinessIdAsync(request.StartId);

            if (linkWithBusinessId != null)
            {
                entityId = linkWithBusinessId.EntityId;
            }
        }

        if (string.IsNullOrWhiteSpace(request.Abc))
        {
            // Si abc est une chaîne vide, renvoyer tous les liens.
            linksContainingAbc = await _linkRepository.GetAllAsync();
        }
        else
        {
            // Sinon, effectuer la recherche avec le critère abc.
            linksContainingAbc = await _linkRepository.GetLinksContainingAbc(request.Abc);
        }

        var startPosition = 0;

        if (entityId != 0)
        {
            startPosition = linksContainingAbc
                .TakeWhile(link => link.EntityId != entityId)
                .Count();
        }

        var pageLinksContainingAbc = linksContainingAbc
            .Skip(startPosition)
            .Take(request.PageSize)
            .ToList();

        var response = new GetPageLinksContainingAbcQueryResponse
        {
            Success = true,
            Message = "Bonjour",
            PageLinksContainingAbc = _mapper.Map<List<PageLinksContainingAbcVm>>(pageLinksContainingAbc),
            TotalItems = linksContainingAbc.ToList().Count,
            ItemPosition = startPosition
        };

        return response;
    }
}
