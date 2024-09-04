using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Commands.CreateLink;

public class CreateLinkCommandHandler(IBaseRepository<Link> linkRepository) : IRequestHandler<CreateLinkCommand, CreateLinkCommandResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<CreateLinkCommandResponse> Handle(CreateLinkCommand request, CancellationToken cancellationToken)
    {
        var link = new Link
        {
            Name = request.Name,
            Description = request.Description,
            Url = request.Url
        };

        link = await _linkRepository.CreateAsync(link);

        return new CreateLinkCommandResponse
        {
            Success = true,
            Message = "Success.",
            LinkId = link.BusinessId
        };
    }
}