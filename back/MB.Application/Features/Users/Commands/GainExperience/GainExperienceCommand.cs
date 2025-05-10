using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.GainExperience;

public record GainExperienceCommand(Guid UserBusinessId, int Xp) : IRequest<BaseResponse>;