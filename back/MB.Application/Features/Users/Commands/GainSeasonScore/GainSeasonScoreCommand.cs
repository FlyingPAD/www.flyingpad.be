using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.GainSeasonScore;

public record GainSeasonScoreCommand(Guid UserBusinessId, int Score) : IRequest<BaseResponse>;