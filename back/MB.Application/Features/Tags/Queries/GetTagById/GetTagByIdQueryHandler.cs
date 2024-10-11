using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagById;

public class GetTagByIdQueryHandler(ITagRepository tagRepository) : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResponse>
{
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<GetTagByIdQueryResponse> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId)
            ?? throw new NotFoundException("Tag not found.");

        var tagCategoryBusinessId = await _tagRepository.GetTagCategoryBusinessId(tag.TagCategoryId);

        var tagToReturn = new GetTagByIdQueryDto 
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
            Message = $"{tag.Name}.",
            Tag = tagToReturn
        };
    }
}