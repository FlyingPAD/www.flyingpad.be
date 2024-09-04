using AutoMapper;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommandHandler(IMapper mapper, IBaseRepository<Artist> artistRepository) : IRequestHandler<CreateArtistCommand, CreateArtistCommandResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;

    public async Task<CreateArtistCommandResponse> Handle(CreateArtistCommand request, CancellationToken cancellationToken)
    {
        var artist = _mapper.Map<Artist>(request);
        artist = await _artistRepository.CreateAsync(artist);

        return new CreateArtistCommandResponse
        {
            Success = true,
            Message = $"The artist '{artist.Name}' has been successfully created.",
            ArtistId = artist.BusinessId
        };
    }
}