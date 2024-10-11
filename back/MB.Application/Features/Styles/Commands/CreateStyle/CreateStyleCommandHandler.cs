using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Commands.CreateStyle;

public class CreateStyleCommandHandler(IBaseRepository<Style> styleRepository) : IRequestHandler<CreateStyleCommand, CreateStyleCommandResponse>
{
    private readonly IBaseRepository<Style> _styleRepository = styleRepository;

    public async Task<CreateStyleCommandResponse> Handle(CreateStyleCommand request, CancellationToken cancellationToken)
    {
        var style = new Style
        {
            Name = request.Name,
            Description = request.Description
        };

        style = await _styleRepository.CreateAsync(style);

        return new CreateStyleCommandResponse
        {
            Success = true,
            Message = "Creation successful.",
            StyleId = style.BusinessId
        };
    }
}