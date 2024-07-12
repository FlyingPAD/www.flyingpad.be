using MB.Application.Contracts.Persistence.Common;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.UpdateLink;

public class UpdateLinkCommandHandler(IBaseRepository<Link> linkRepository) : IRequestHandler<UpdateLinkCommand, BaseResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<BaseResponse> Handle(UpdateLinkCommand request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetByBusinessIdAsync(request.BusinessId);

        if (link == null)
        {
            return new BaseResponse { Success = false, Message = "Link wasn't found." };
        }

        link.Name = request.Name;
        link.Description = request.Description;
        link.Url = request.Url;

        await _linkRepository.UpdateAsync(link);

        return new BaseResponse
        {
            Success = true,
            Message = "Update Successfull."
        };
    }
}