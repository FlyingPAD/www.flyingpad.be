using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.TagCategoryAggregate;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandHandler(IBaseRepository<TagCategory> tagCategoryRepository) : IRequestHandler<DeleteTagCategoryCommand, BaseResponse>
{
    private readonly IBaseRepository<TagCategory> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(DeleteTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId) 
            ?? throw new NotFoundException($"Tag category not found.");

        await _tagCategoryRepository.DeleteAsync(tagCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Tag category was deleted."
        };
    }
}