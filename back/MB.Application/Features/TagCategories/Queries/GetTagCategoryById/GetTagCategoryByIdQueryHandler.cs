using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoryById;

public class GetTagCategoryByIdQueryHandler : IRequestHandler<GetTagCategoryByIdQuery, GetTagCategoryByIdQueryResponse>
{
    private readonly IMapper _mapper;
    private IBaseRepository<TagCategory> _tagCategoryRepository;

    public GetTagCategoryByIdQueryHandler(IMapper mapper, IBaseRepository<TagCategory> tagCategoryRepository)
    {
        _mapper = mapper;
        _tagCategoryRepository = tagCategoryRepository;
    }

    public async Task<GetTagCategoryByIdQueryResponse> Handle(GetTagCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.Id);

        if (tagCategory == null)
        {
            return new GetTagCategoryByIdQueryResponse { Success = false, Message = "TagCategory wasn't found :(" };
        }

        var tagCategoryDto = _mapper.Map<GetTagCategoryByIdVm>(tagCategory);

        return new GetTagCategoryByIdQueryResponse
        {
            Success = true,
            Message = "TagCategory was found :)",
            TagCategory = tagCategoryDto
        };
    }
}
