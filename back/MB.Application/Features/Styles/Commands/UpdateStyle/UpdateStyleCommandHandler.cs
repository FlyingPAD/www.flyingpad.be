using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Commands.UpdateStyle;

public class UpdateStyleCommandHandler(IBaseRepository<Style> styleRepository) : IRequestHandler<UpdateStyleCommand, BaseResponse>
{
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<BaseResponse> Handle(UpdateStyleCommand request, CancellationToken cancellationToken)
    {
        var style = await _styleRepository.GetByBusinessIdAsync(request.BusinessId)
            ?? throw new NotFoundException($"Style with ID {request.BusinessId} was not found.");

        style.Name = request.Name;
        style.Description = request.Description;

        await _styleRepository.UpdateAsync(style);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}