﻿using MB.Application.Exceptions;
using MB.Application.Features.Moods.Mapper;
using MB.Application.Interfaces.Persistence.Definitions;
using MediatR;

namespace MB.Application.Features.Moods.Queries.GetMoodsByArtist;

public class GetMoodsByArtistQueryHandler(IMoodRepository moodRepository, IArtistRepository artistRepository) : IRequestHandler<GetMoodsByArtistQuery, GetMoodsByArtistQueryResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<GetMoodsByArtistQueryResponse> Handle(GetMoodsByArtistQuery request, CancellationToken cancellationToken)
    {
        var artistId = await _artistRepository.GetEntityIdByBusinessIdAsync(request.ArtistId, cancellationToken)
            ?? throw new NotFoundException("Artist not found.");

        var moods = await _moodRepository.GetMoodsByArtist(artistId);

        var dtos = MoodMapper.ToListItemDtos(moods);

        return new GetMoodsByArtistQueryResponse
        {
            Success = true,
            Message = "Moods by artist.",
            Moods = dtos
        };
    }
}