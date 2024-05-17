using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteLinkCommandHandler : IRequestHandler<DeleteLinkCommand, DeleteLinkCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IBaseRepository<Link> _linkRepository;

    public DeleteLinkCommandHandler(IMapper mapper, IBaseRepository<Link> linkRepository)
    {
        _mapper = mapper;
        _linkRepository = linkRepository;
    }

    public async Task<DeleteLinkCommandResponse> Handle(DeleteLinkCommand request, CancellationToken cancellationToken)
    {
        var deleteLinkCommandResponse = new DeleteLinkCommandResponse();

        var validator = new DeleteLinkCommandValidator();
        var validationResult = await validator.ValidateAsync(request);

        if (validationResult.Errors.Count > 0)
        {
            deleteLinkCommandResponse.Success = false;
            deleteLinkCommandResponse.ValidationErrors = new List<string>();
            foreach (var error in validationResult.Errors)
            {
                deleteLinkCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }
        }
        if (deleteLinkCommandResponse.Success)
        {
            var link = await _linkRepository.GetByBusinessIdAsync(request.LinkId);
            if (link != null)
            {
                await _linkRepository.DeleteAsync(link);
                deleteLinkCommandResponse.Success = true;
            }
            else
            {
                deleteLinkCommandResponse.Success = false;
                deleteLinkCommandResponse.ValidationErrors = new List<string>
                {
                    "Selected link doesn't exist."
                };
            }
        }

        return deleteLinkCommandResponse;
    }
}
