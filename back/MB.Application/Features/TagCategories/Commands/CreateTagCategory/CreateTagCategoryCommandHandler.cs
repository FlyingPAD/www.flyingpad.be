using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.CreateTagCategory;

public class CreateTagCategoryCommandHandler(IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<CreateTagCategoryCommand, CreateTagCategoryCommandResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<CreateTagCategoryCommandResponse> Handle(CreateTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = new TagCategory
        {
            Name = request.Name,
            Description = request.Description
        };

        tagCategory = await _tagCategoryRepository.CreateAsync(tagCategory);

        return new CreateTagCategoryCommandResponse
        {
            Success = true,
            Message = "Success.",
            TagCategoryId = tagCategory.BusinessId
        };
    }
}