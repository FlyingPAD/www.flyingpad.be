﻿using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.LinkCategories.Queries.GetAllLinkCategories;

public class GetAllLinkCategoriesQueryHandler(IBaseRepository<LinkCategory> linkCategoryRepository, IMapper mapper) : IRequestHandler<GetAllLinkCategoriesQuery, GetAllLinkCategoriesQueryResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetAllLinkCategoriesQueryResponse> Handle(GetAllLinkCategoriesQuery request, CancellationToken cancellationToken)
    {
        var linkCategories = await _linkCategoryRepository.GetAllAsync(category => category.Name);

        return new GetAllLinkCategoriesQueryResponse
        {
            Success = true,
            Message = "All link categories.",
            LinkCategories = _mapper.Map<List<GetAllLinkCategoriesQueryDto>>(linkCategories)
        };
    }
}