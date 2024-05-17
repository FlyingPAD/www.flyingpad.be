using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Artists.Commands.CreateArtist;

public class CreateArtistCommandHandler(IMapper mapper, IBaseRepository<Artist> artistRepository, CreateArtistCommandValidator validator) : IRequestHandler<CreateArtistCommand, CreateArtistCommandResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Artist> _artistRepository = artistRepository;
    private readonly CreateArtistCommandValidator _validator = validator;

    public async Task<CreateArtistCommandResponse> Handle(CreateArtistCommand request, CancellationToken cancellationToken)
    {
        //  => Validation

        // Errors :

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            return new CreateArtistCommandResponse
            {
                Message = "Error(s)...",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

        // Success :

        var artist = new Artist { Name = request.Name };

        artist = await _artistRepository.CreateAsync(artist);

        return new CreateArtistCommandResponse
        {
            Success = true,
            Message = $"The artist '{artist.Name}' has been successfully created.",
            Artist = _mapper.Map<CreateArtistDto>(artist)
        };
    }
}