using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory;

public class GetTagsByCategoryQueryHandler(IMapper mapper, ITagRepository tagRepository, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<GetTagsByCategoryQuery, GetTagsByCategoryQueryResponse>
{
    public readonly IMapper _mapper = mapper;
    public readonly ITagRepository _tagRepository = tagRepository;
    public readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<GetTagsByCategoryQueryResponse> Handle(GetTagsByCategoryQuery request, CancellationToken cancellationToken)
    {
        var categoryId = await _tagCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.CategoryId)
            ?? throw new NotFoundException("Tag category not found.");

        var tags = await _tagRepository.GetByCategory(categoryId);

        var tagsDto = _mapper.Map<List<GetTagsByCategoryQueryDto>>(tags);

        return new GetTagsByCategoryQueryResponse
        {
            Success = true,
            Message = "Tags by category.",
            Tags = tagsDto
        };
    }
}