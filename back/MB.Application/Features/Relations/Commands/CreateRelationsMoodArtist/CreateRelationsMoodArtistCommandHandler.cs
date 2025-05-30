using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsMoodArtist;

public class CreateRelationsMoodArtistCommandHandler(IMoodRepository moodRepository, IArtistRepository artistRepository) : IRequestHandler<CreateRelationsMoodArtistCommand, BaseResponse>
{
    private readonly IMoodRepository _moodRepository = moodRepository;
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<BaseResponse> Handle(CreateRelationsMoodArtistCommand request, CancellationToken cancellationToken)
    {
        var moodId = await _moodRepository.GetEntityIdByBusinessIdAsync(request.MoodId)
            ?? throw new NotFoundException("Mood not found.");

        var artistsPrimaryIds = await _artistRepository.GetPrimaryIdsByBusinessIdsAsync(request.ArtistIds);

        if (artistsPrimaryIds.Count != request.ArtistIds.Count)
        {
            throw new NotFoundException("One or more artists were not found.");
        }

        await _moodRepository.UpdateArtists(moodId, artistsPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Artists updated."
        };
    }
}