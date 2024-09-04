using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence.Common;
using MB.Application.Models;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.UpdateArtist;

public class UpdateArtistCommandHandler(IBaseRepository<Artist> artistRepository) : IRequestHandler<UpdateArtistCommand, BaseResponse>
{
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<BaseResponse> Handle(UpdateArtistCommand request, CancellationToken cancellationToken)
    {
        var artist = await _artistRepository.GetByBusinessIdAsync(request.BusinessId)
            ?? throw new NotFoundException($"Artist with ID {request.BusinessId} was not found.");

        artist.Name = request.Name;
        artist.Description = request.Description;

        await _artistRepository.UpdateAsync(artist);

        return new BaseResponse
        {
            Success = true,
            Message = "Success."
        };
    }
}