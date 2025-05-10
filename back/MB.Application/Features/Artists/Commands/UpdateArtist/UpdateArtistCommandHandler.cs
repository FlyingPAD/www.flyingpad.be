using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommandHandler(IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<UpdateArtistCommand, BaseResponse>
{
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<BaseResponse> Handle(UpdateArtistCommand request, CancellationToken cancellationToken)
    {
        var artistId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId)
            ?? throw new NotFoundException("Artist not found.");

        var artist = await _artistRepository.GetArtistWithStylesAsync(artistId)
            ?? throw new NotFoundException("Artist not found.");

        artist.Name = request.Name;
        artist.Description = request.Description;

        await _artistRepository.UpdateAsync(artist);

        await _artistRepository.RemoveArtistStylesAsync(artist);

        var styleIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);

        if (styleIds.Count != request.StyleIds.Count)
        {
            throw new NotFoundException("One or more style(s) not found.");
        }

        await _artistRepository.AddArtistStylesAsync(artistId, styleIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Update successful."
        };
    }
}