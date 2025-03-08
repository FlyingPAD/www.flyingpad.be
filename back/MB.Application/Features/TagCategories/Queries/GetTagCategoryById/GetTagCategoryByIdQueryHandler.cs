using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.TagCategoryAggregate;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQueryHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<GetTagCategoryByIdQuery, GetTagCategoryByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<GetTagCategoryByIdQueryResponse> Handle(GetTagCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId)
            ?? throw new NotFoundException("Tag category not found.");

        return new GetTagCategoryByIdQueryResponse
        {
            Success = true,
            Message = $"{tagCategory.Name}.",
            TagCategory = _mapper.Map<GetTagCategoryByIdQueryDto>(tagCategory)
        };
    }
}