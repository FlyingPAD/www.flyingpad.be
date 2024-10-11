using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.CreateFranchise;

public class CreateFranchiseCommandHandler(IFranchiseRepository franchiseRepository, IMediaRepository mediaRepository) : IRequestHandler<CreateFranchiseCommand, CreateFranchiseCommandResponse>
{
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
    private readonly IMediaRepository _mediaRepository = mediaRepository;

    public async Task<CreateFranchiseCommandResponse> Handle(CreateFranchiseCommand request, CancellationToken cancellationToken)
    {
        var franchise = new Franchise
        {
            Name = request.Name,
            Description = request.Description
        };

        franchise = await _franchiseRepository.CreateAsync(franchise);

        var mediaIds = await _mediaRepository.GetPrimaryIdsByBusinessIdsAsync(request.MediaIds);

        if (mediaIds.Count != request.MediaIds.Count)
        {
            throw new NotFoundException("One or more media were not found.");
        }

        await _franchiseRepository.AddMediaAsync(franchise.EntityId, mediaIds);

        return new CreateFranchiseCommandResponse
        {
            Success = true,
            Message = "Franchise was created.",
            FranchiseId = franchise.BusinessId
        };
    }
}