using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Artists.Commands.DeleteArtist;

public class DeleteArtistCommandHandler(IArtistRepository artistRepository) : IRequestHandler<DeleteArtistCommand, BaseResponse>
{
    private readonly IArtistRepository _artistRepository = artistRepository;

    public async Task<BaseResponse> Handle(DeleteArtistCommand request, CancellationToken cancellationToken)
    {
        var artist = await _artistRepository.GetByBusinessIdAsync(request.BusinessId)
            ?? throw new NotFoundException($"Artist with ID {request.BusinessId} was not found.");

        await _artistRepository.DeleteArtistRelations(artist.EntityId);
        await _artistRepository.DeleteAsync(artist);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}