using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Tags.Commands.UpdateTag;

public class UpdateTagCommand : IRequest<BaseResponse>
{
    public Guid TagId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Guid TagCategoryId { get; set; }
}