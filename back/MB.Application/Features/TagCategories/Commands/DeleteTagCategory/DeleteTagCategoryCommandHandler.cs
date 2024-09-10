using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandHandler(ITagCategoryRepository tagCategoryRepository) : IRequestHandler<DeleteTagCategoryCommand, BaseResponse>
{
    private readonly ITagCategoryRepository _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(DeleteTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId) 
            ?? throw new NotFoundException($"Tag Category with ID {request.TagCategoryId} was not found.");

        await _tagCategoryRepository.DeleteTagCategoryTags(tagCategory.EntityId);
        await _tagCategoryRepository.DeleteAsync(tagCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}