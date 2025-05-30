using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Moods.Commands.ApproveMoods;

public class ApproveMoodsCommand : IRequest<BaseResponse>
{
    public List<Guid> MoodIds { get; set; } = [];
}