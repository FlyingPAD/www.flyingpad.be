using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Users.Commands.GainExperience;

public class GainExperienceCommandHandler(IUserRepository userRepo) : IRequestHandler<GainExperienceCommand, BaseResponse>
{
    private readonly IUserRepository _userRepo = userRepo;

    public async Task<BaseResponse> Handle(GainExperienceCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepo
            .GetByBusinessIdWithAchievementsAsync(request.UserBusinessId)
            ?? throw new NotFoundException("User not found.");

        user.GainExperience(request.Xp);
        await _userRepo.UpdateAsync(user);

        return new BaseResponse { Success = true, Message = "Experience added." };
    }
}