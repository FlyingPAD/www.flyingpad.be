using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsByCategory;

public class GetTagsByCategoryQueryHandler(IMapper mapper, GetTagsByCategoryQueryValidator validator, ITagRepository tagRepository, ITagCategoryRepository tagCategoryRepository) : IRequestHandler<GetTagsByCategoryQuery, GetTagsByCategoryQueryResponse>
{
    public readonly IMapper _mapper = mapper;
    public readonly GetTagsByCategoryQueryValidator _validator = validator;
    public readonly ITagRepository _tagRepository = tagRepository;
    public readonly ITagCategoryRepository _tagCategoryRepository = tagCategoryRepository;

    public async Task<GetTagsByCategoryQueryResponse> Handle(GetTagsByCategoryQuery request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            return new GetTagsByCategoryQueryResponse
            {
                Message = "Error(s)...",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

        var categoryId = await _tagCategoryRepository.GetPrimaryIdByBusinessIdAsync(request.CategoryId);

        var tags = await _tagRepository.GetByCategory((int)categoryId);

        var tagsDto = _mapper.Map<List<GetTagsByCategoryQueryDto>>(tags);

        return new GetTagsByCategoryQueryResponse
        {
            Success = true,
            Tags = tagsDto
        };
    }
}