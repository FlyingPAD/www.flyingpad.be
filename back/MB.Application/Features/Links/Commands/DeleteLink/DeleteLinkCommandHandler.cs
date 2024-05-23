using MB.Application.Contracts.Persistence.Common;
using MB.Application.Features.Links.Commands.DeleteLink;
using MB.Application.Responses;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteLinkCommandHandler(IBaseRepository<Link> linkRepository) : IRequestHandler<DeleteLinkCommand, BaseResponse>
{
    private readonly IBaseRepository<Link> _linkRepository = linkRepository;

    public async Task<BaseResponse> Handle(DeleteLinkCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse();
        var validator = new DeleteLinkCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            foreach (var error in validationResult.Errors)
            {
                response.ValidationErrors.Add(error.ErrorMessage);
            }
            return response;
        }

        var link = await _linkRepository.GetByBusinessIdAsync(request.LinkId);

        if (link != null)
        {
            await _linkRepository.DeleteAsync(link);
            response.Success = true;
        }
        else
        {
            response.Success = false;
            response.Message = "Link was not found.";
        }

        return response;
    }
}