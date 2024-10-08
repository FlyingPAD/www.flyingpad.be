﻿using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Commands.UpdateMoodScore;

public class UpdateMoodScoreCommandHandler(IMoodRepository repository) : IRequestHandler<UpdateMoodScoreCommand, UpdateMoodScoreCommandResponse>
{
    private readonly IMoodRepository _repository = repository;

    public async Task<UpdateMoodScoreCommandResponse> Handle(UpdateMoodScoreCommand request, CancellationToken cancellationToken)
    {
        int? entityId = await _repository.GetPrimaryIdByBusinessIdAsync(request.BusinessId);

        await _repository.UpdateScore(entityId, request.Value);

        return new UpdateMoodScoreCommandResponse
        {
            Success = true,
            Message = "Mood Score updated !"
        };
    }
}