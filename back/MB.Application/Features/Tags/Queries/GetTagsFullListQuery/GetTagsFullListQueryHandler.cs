﻿using AutoMapper;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery;

public class GetTagsFullListQueryHandler(IMapper mapper, ITagRepository tagRepository) : IRequestHandler<GetTagsFullListQuery, GetTagsFullListQueryResponse>
{
    private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    private readonly ITagRepository _tagRepository = tagRepository ?? throw new ArgumentNullException(nameof(tagRepository));

    public async Task<GetTagsFullListQueryResponse> Handle(GetTagsFullListQuery request, CancellationToken cancellationToken)
    {
        var categoriesWithTags = await _tagRepository.GetTagsFullListAsync();

        var categoriesWithTagsDto = _mapper.Map<List<GetTagsFullListQueryDto>>(categoriesWithTags);

        return new GetTagsFullListQueryResponse
        {
            Success = true,
            Message = "Tags & Categories were loaded.",
            CategoriesWithTags = categoriesWithTagsDto
        };
    }
}