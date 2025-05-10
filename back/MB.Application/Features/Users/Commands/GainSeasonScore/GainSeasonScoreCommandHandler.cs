using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.GainSeasonScore;

public class GainSeasonScoreCommandHandler(IUserRepository userRepo) : IRequestHandler<GainSeasonScoreCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<BaseResponse> Handle(
        GainSeasonScoreCommand request,
        CancellationToken ct)
    {
        var user = await _userRepo
            .GetByBusinessIdAsync(request.UserBusinessId)
            ?? throw new NotFoundException($"Utilisateur {request.UserBusinessId} introuvable.");

        user.GainSeasonPoints(request.Score);
        await _userRepo.UpdateAsync(user);

        return new BaseResponse
        {
            Success = true,
            Message = "Season score mis à jour."
        };
    }
}