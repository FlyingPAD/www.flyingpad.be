using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsFullListQuery
{
    public class GetTagsFullListQueryHandler(IMapper mapper, ITagRepository tagRepository) : IRequestHandler<GetTagsFullListQuery, GetTagsFullListQueryResponse>
    {
        private readonly IMapper _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        private readonly ITagRepository _tagRepository = tagRepository ?? throw new ArgumentNullException(nameof(tagRepository));

        public async Task<GetTagsFullListQueryResponse> Handle(GetTagsFullListQuery request, CancellationToken cancellationToken)
        {
            var categoriesWithTags = await _tagRepository.GetTagsFullListAsync();

            var categoriesWithTagsVm = _mapper.Map<List<GetTagsFullListQueryVm>>(categoriesWithTags);

            return new GetTagsFullListQueryResponse
            {
                Success = true,
                Message = "Tags and their categories retrieved successfully.",
                CategoriesWithTags = categoriesWithTagsVm
            };
        }
    }
}