using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.TagCategories.Commands.DeleteTagCategory;

public class DeleteTagCategoryCommandHandler(IBaseRepository<Tag> tagCategoryRepository) : IRequestHandler<DeleteTagCategoryCommand, BaseResponse>
{
    private readonly IBaseRepository<Tag> _tagCategoryRepository = tagCategoryRepository;

    public async Task<BaseResponse> Handle(DeleteTagCategoryCommand request, CancellationToken cancellationToken)
    {
        var tagCategory = await _tagCategoryRepository.GetByBusinessIdAsync(request.TagCategoryId) 
            ?? throw new NotFoundException($"Tag Category not found.");

        await _tagCategoryRepository.DeleteAsync(tagCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}