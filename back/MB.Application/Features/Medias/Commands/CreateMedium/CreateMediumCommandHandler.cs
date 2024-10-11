using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Commands.CreateMedium;

public class CreateMediumCommandHandler(IBaseRepository<Media> mediaRepository) : IRequestHandler<CreateMediumCommand, CreateMediumCommandResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;

    public async Task<CreateMediumCommandResponse> Handle(CreateMediumCommand request, CancellationToken cancellationToken)
    {
        var medium = new Media
        {
            Name = request.Name,
            Description = request.Description,
        };

        medium = await _mediaRepository.CreateAsync(medium);

        return new CreateMediumCommandResponse
        {
            Success = true,
            Message = "Medium was created.",
            MediumId = medium.BusinessId
        };
    }
}