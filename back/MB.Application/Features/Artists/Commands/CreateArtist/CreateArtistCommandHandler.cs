using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommandHandler(IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<CreateArtistCommand, CreateArtistCommandResponse>
{
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<CreateArtistCommandResponse> Handle(CreateArtistCommand request, CancellationToken cancellationToken)
    {
        var artist = new Artist
        {
            Name = request.Name,
            Description = request.Description,
        };

        artist = await _artistRepository.CreateAsync(artist);

        var styleIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);

        if (styleIds.Count != request.StyleIds.Count)
        {
            throw new NotFoundException("One or more style(s) not found.");
        }

        await _artistRepository.AddArtistStylesAsync(artist.EntityId, styleIds);

        return new CreateArtistCommandResponse
        {
            Success = true,
            Message = "Creation successful.",
            ArtistId = artist.BusinessId
        };
    }
}