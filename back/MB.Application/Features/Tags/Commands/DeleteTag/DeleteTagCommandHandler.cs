using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Commands.DeleteTag;

public class DeleteTagCommandHandler(IBaseRepository<Tag> tagRepository) : IRequestHandler<DeleteTagCommand, BaseResponse>
{
    private readonly IBaseRepository<Tag> _tagRepository = tagRepository;

    public async Task<BaseResponse> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
    {
        var tag = await _tagRepository.GetByBusinessIdAsync(request.TagId)
            ?? throw new NotFoundException("Tag not found.");

        await _tagRepository.DeleteAsync(tag);

        return new BaseResponse
        {
            Success = true,
            Message = "Tag was deleted."
        };
    }
}