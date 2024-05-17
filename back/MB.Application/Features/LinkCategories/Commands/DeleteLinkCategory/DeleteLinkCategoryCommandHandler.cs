using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.LinkCategories.Commands.DeleteLinkCategory;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteLinkCategoryCommandHandler(IBaseRepository<LinkCategory> linkCategoryRepository) : IRequestHandler<DeleteLinkCategoryCommand, DeleteLinkCategoryCommandResponse>
{
    private readonly IBaseRepository<LinkCategory> _linkCategoryRepository = linkCategoryRepository;

    public async Task<DeleteLinkCategoryCommandResponse> Handle(DeleteLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var deleteLinkCategoryCommandResponse = new DeleteLinkCategoryCommandResponse();

        var validator = new DeleteLinkCategoryCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            deleteLinkCategoryCommandResponse.Success = false;
            deleteLinkCategoryCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteLinkCategoryCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteLinkCategoryCommandResponse.Success)
        {
            var linkCategory = await _linkCategoryRepository.GetByBusinessIdAsync(request.LinkCategoryId);
            if (linkCategory != null)
            {
                await _linkCategoryRepository.DeleteAsync(linkCategory);
                deleteLinkCategoryCommandResponse.Success = true;
            }
            else
            {
                deleteLinkCategoryCommandResponse.Success = false;
                deleteLinkCategoryCommandResponse.ValidationErrors = new List<string>
                {
                    "Selected linkCategory doesn't exist."
                };
            }
        }

        return deleteLinkCategoryCommandResponse;
    }
}
