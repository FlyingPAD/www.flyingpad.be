using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Tags.Commands.DeleteTag;

public class DeleteTagCommandHandler(ITagRepository tagRepository) : IRequestHandler<DeleteTagCommand, BaseResponse>
{
    private readonly ITagRepository _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId)
            ?? throw new NotFoundException($"Tag with ID {request.TagId} was not found.");

        await _tagRepository.DeleteTagRelations(tag.EntityId);
        await _tagRepository.DeleteAsync(tag);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}