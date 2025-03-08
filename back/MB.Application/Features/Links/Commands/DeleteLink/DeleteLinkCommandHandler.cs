using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MB.Domain.LinkAggregate;
using MediatR;

namespace MB.Application.Features.Links.Commands.DeleteLink;

public class DeleteLinkCommandHandler(IBaseRepository<Link> linkRepository) : IRequestHandler<DeleteLinkCommand, BaseResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<BaseResponse> Handle(DeleteLinkCommand request, CancellationToken cancellationToken)
    {
        var link = await _linkRepository.GetByBusinessIdAsync(request.LinkId) 
            ?? throw new NotFoundException($"Link not found.");

        await _linkRepository.DeleteAsync(link);

        return new BaseResponse
        {
            Success = true,
            Message = "Link was deleted."
        };
    }
}