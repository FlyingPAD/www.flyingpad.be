using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryHandler(ITagRepository tagRepository) : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResponse>
{
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetTagByIdQueryResponse> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId);

        if (tag == null)
        {
            return new GetTagByIdQueryResponse { Success = false, Message = "Tag was not found." };
        }

        var tagCategoryBusinessId = await _tagRepository.GetTagCategoryBusinessId(tag.TagCategoryId);

        var tagToReturn = new GetTagByIdVm 
        {
            BusinessId  = tag.BusinessId,
            Name = tag.Name,
            Description = tag.Description,
            Created = tag.Created,
            CreatedBy = tag.CreatedBy,
            Modified = tag.Modified,
            ModifiedBy = tag.ModifiedBy,
            TagCategoryId  = tagCategoryBusinessId
        };

        return new GetTagByIdQueryResponse
        {
            Success = true,
            Message = "Success",
            Tag = tagToReturn
        };
    }
}