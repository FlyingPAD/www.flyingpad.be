using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.LinkCategoryAggregate;
using MediatR;

namespace MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;

public class DeleteLinkCategoryCommandHandler(IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<DeleteLinkCategoryCommand, BaseResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<BaseResponse> Handle(DeleteLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId) 
            ?? throw new NotFoundException($"Link category not found.");

        await _linkCategoryRepository.DeleteAsync(linkCategory);

        return new BaseResponse
        {
            Success = true,
            Message = "Link category was deleted."
        };
    }
}