﻿using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetAllLinks;

public class GetAllLinksQueryHandler(IBaseRepository<Link> linkRepository, IMapper mapper) : IRequestHandler<GetAllLinksQuery, GetAllLinksQueryResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllLinksQueryResponse> Handle(GetAllLinksQuery request, CancellationToken cancellationToken)
    {
        var links = await _linkRepository.GetAllAsync(link => link.Name);

        return new GetAllLinksQueryResponse
        {
            Success = true,
            Message = "All links.",
            Links = _mapper.Map<List<GetAllLinksQueryDto>>(links)
        };
    }
}