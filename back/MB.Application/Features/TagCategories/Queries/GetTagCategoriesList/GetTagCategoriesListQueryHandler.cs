using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Queries.GetTagCategoriesList;

public class GetTagCategoriesListQueryHandler(IBaseRepository<TagCategory> tagCategoryRepository, IMapper mapper) : IRequestHandler<GetTagCategoriesListQuery, GetTagCategoriesListQueryResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetTagCategoriesListQueryResponse> Handle(GetTagCategoriesListQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var tagCategories = await _tagCategoryRepository.GetAllAsync(x => x.Name, true);
            var response = new GetTagCategoriesListQueryResponse
            {
                Success = true,
                Message = "Success !",
                TagCategories = _mapper.Map<List<TagCategoryListVm>>(tagCategories)
            };

            return response;
        }
        catch (Exception ex)
        {
            // Gérez l'exception et renvoyez une réponse d'erreur
            var response = new GetTagCategoriesListQueryResponse
            {
                Success = false,
                ValidationErrors = ["Error ( " + ex + " )."]
            };

            return response;
        }
    }
}
