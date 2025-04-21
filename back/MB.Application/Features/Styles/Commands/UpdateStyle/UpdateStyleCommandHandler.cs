using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.StyleAggregate;
using MediatR;

namespace MB.Application.Features.Styles.Commands.UpdateStyle;

public class UpdateStyleCommandHandler(IBaseRepository<Style> styleRepository) : IRequestHandler<UpdateStyleCommand, BaseResponse>
{
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<BaseResponse> Handle(UpdateStyleCommand request, CancellationToken cancellationToken)
    {
        var style = await _styleRepository.GetByBusinessIdAsync(request.StyleId)
            ?? throw new NotFoundException("Style not found.");

        style.Name = request.Name;
        style.Description = request.Description;

        await _styleRepository.UpdateAsync(style);

        return new BaseResponse
        {
            Success = true,
            Message = "Update successful."
        };
    }
}