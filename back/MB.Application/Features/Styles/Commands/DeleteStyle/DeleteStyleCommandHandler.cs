using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Styles.Commands.DeleteStyle;

public class DeleteStyleCommandHandler(IStyleRepository styleRepository) : IRequestHandler<DeleteStyleCommand, BaseResponse>
{
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<BaseResponse> Handle(DeleteStyleCommand request, CancellationToken cancellationToken)
    {
        var style = await _styleRepository.GetByBusinessIdAsync(request.StyleId)
            ?? throw new NotFoundException($"Style with ID {request.StyleId} was not found.");

        await _styleRepository.DeleteStyleRelations(style.EntityId);
        await _styleRepository.DeleteAsync(style);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}