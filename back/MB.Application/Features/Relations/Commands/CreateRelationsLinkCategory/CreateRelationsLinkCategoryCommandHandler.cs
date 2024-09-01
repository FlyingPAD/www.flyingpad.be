using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsLinkCategory;

public class CreateRelationsLinkCategoryCommandHandler : IRequestHandler<CreateRelationsLinkCategoryCommand, BaseResponse>
{
    private readonly ILinkRepository _linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository;
    private readonly CreateRelationsLinkCategoryCommandValidator _validator;

    public CreateRelationsLinkCategoryCommandHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository, CreateRelationsLinkCategoryCommandValidator validator)
    {
        _linkRepository = linkRepository;
        _linkCategoryRepository = linkCategoryRepository;
        _validator = validator;
    }

    public async Task<BaseResponse> Handle(CreateRelationsLinkCategoryCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Validation Error(s)",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

        var linkPrimaryId = await _linkRepository.GetPrimaryIdByBusinessIdAsync(request.LinkId);
        if (linkPrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Link was not found."
            };
        }

        var categoryPrimaryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.CategoryIds);
        if (categoryPrimaryIds.Count != request.CategoryIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more categories were not found."
            };
        }

        await _linkRepository.UpdateCategories((int)linkPrimaryId, categoryPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}