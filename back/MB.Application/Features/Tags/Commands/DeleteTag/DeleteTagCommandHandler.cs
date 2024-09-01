using MB.Application.Contracts.Persistence;
using MB.Application.Features.Tags.Commands.DeleteTag;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Task.Commands.DeleteTask;

public class DeleteTagCommandHandler(ITagRepository tagRepository) : IRequestHandler<DeleteTagCommand, BaseResponse>
{
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var response = new BaseResponse();

        var validator = new DeleteTagCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            response.Success = false;
            response.ValidationErrors = [];
            foreach (var error in validationResult.Errors)
            {
                response.ValidationErrors.Add(error.ErrorMessage);
            }

            return response;
        }

        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId);

        if (tag != null)
        {
            await _tagRepository.DeleteTagRelations(tag.EntityId);
            await _tagRepository.DeleteAsync(tag);
            response.Success = true;
        }
        else
        {
            response.Success = false;
            response.ValidationErrors = ["Selected tag doesn't exist."];
        }

        return response;
    }
}