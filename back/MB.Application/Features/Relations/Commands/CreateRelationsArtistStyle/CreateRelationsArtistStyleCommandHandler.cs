using MB.Application.Exceptions;
using MB.Application.Features.Relations.Commands.RAS;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsArtistStyle;

public class CreateRelationsArtistStyleCommandHandler(IArtistRepository artistRepository, IStyleRepository styleRepository) : IRequestHandler<CreateRelationsArtistStyleCommand, BaseResponse>
{
    private readonly IArtistRepository _artistRepository = artistRepository;
    private readonly IStyleRepository _styleRepository = styleRepository;

    public async Task<BaseResponse> Handle(CreateRelationsArtistStyleCommand request, CancellationToken cancellationToken)
    {
        var artistId = await _artistRepository.GetPrimaryIdByBusinessIdAsync(request.ArtistId)
            ?? throw new NotFoundException("Artist not found.");

        var stylesIds = await _styleRepository.GetPrimaryIdsByBusinessIdsAsync(request.StyleIds);

        if (stylesIds.Count != request.StyleIds.Count)
        {
            throw new NotFoundException("One or more styles were not found.");
        }

        await _artistRepository.UpdateStyles(artistId, stylesIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}