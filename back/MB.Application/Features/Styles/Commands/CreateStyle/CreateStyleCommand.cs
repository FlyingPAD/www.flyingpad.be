using MediatR;

namespace MB.Application.Features.Styles.Commands.CreateStyle
{
    public class CreateStyleCommand : IRequest<CreateStyleCommandResponse>
    {
        public string Name { get; set; } = string.Empty;
    }
}
