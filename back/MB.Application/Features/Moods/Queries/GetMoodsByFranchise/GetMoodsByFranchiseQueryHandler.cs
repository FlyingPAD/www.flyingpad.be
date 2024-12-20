﻿using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByFranchise;

public class GetMoodsByFranchiseQueryHandler(IMapper mapper, IModelRepository modelRepository, IMoodRepository moodRepository, IFranchiseRepository franchiseRepository) : IRequestHandler<GetMoodsByFranchiseQuery, GetMoodsByFranchiseQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;

    public async Task<GetMoodsByFranchiseQueryResponse> Handle(GetMoodsByFranchiseQuery request, CancellationToken cancellationToken)
    {
        int franchiseId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        var models = await _modelRepository.GetModelsByFranchise(franchiseId);

        var modelIds = models.Select(model => model.EntityId).ToList();

        var moods = await _moodRepository.GetMoodsByModels(modelIds);

        return new GetMoodsByFranchiseQueryResponse
        {
            Success = true,
            Message = "Moods by franchise.",
            Moods = _mapper.Map<List<GetMoodsByFranchiseQueryDto>>(moods)
        };
    }
}