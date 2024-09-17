using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommandHandler(ILinkRepository linkRepository, ILinkCategoryRepository linkCategoryRepository) : IRequestHandler<UpdateLinkCommand, BaseResponse>
{
    private readonly ILinkRepository _linkRepository = linkRepository;
    private readonly ILinkCategoryRepository _linkCategoryRepository = linkCategoryRepository;

    public async Task<BaseResponse> Handle(UpdateLinkCommand request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetByBusinessIdAsync(request.BusinessId)
            ?? throw new DirectoryNotFoundException("Link not found.");

        link.Name = request.Name;
        link.Description = request.Description;
        link.Url = request.Url;
        await _linkRepository.UpdateAsync(link);

        var categoryIds = await _linkCategoryRepository.GetPrimaryIdsByBusinessIdsAsync(request.LinkCategories);

        if (categoryIds.Count != request.LinkCategories.Count)
        {
            throw new NotFoundException("One or more categories were not found.");
        }

        await _linkRepository.UpdateCategories(link.EntityId, categoryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Update successful."
        };
    }
}