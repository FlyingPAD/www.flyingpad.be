using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;

public class GetTagCategoriesListQueryHandler : IRequestHandler<GetTagCategoriesListQuery, GetTagCategoriesListQueryResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository;
    private readonly IMapper _mapper;

    public GetTagCategoriesListQueryHandler(IBaseRepository<TagCategory> tagCategoryRepository, IMapper mapper)
    {
        _tagCategoryRepository = tagCategoryRepository;
        _mapper = mapper;
    }

    public async Task<GetTagCategoriesListQueryResponse> Handle(GetTagCategoriesListQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var tagCategories = await _tagCategoryRepository.GetAllAsync();
            var response = new GetTagCategoriesListQueryResponse
            {
                Success = true,
                Message = "Here are the TagCategories !",
                TagCategoriesList = _mapper.Map<List<TagCategoryListVm>>(tagCategories)
            };

            return response;
        }
        catch (Exception ex)
        {
            // Gérez l'exception et renvoyez une réponse d'erreur
            var response = new GetTagCategoriesListQueryResponse
            {
                Success = false,
                ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
            };

            return response;
        }
    }
}
