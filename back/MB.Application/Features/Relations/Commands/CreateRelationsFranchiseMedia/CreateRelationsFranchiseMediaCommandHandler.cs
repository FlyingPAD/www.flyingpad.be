using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsFranchiseMedia;

public class CreateRelationsFranchiseMediaCommandHandler(IFranchiseRepository franchiseRepository, IMediaRepository mediaRepository) : IRequestHandler<CreateRelationsFranchiseMediaCommand, BaseResponse>
{
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
    private readonly IMediaRepository _mediaRepository = mediaRepository;

    public async Task<BaseResponse> Handle(CreateRelationsFranchiseMediaCommand request, CancellationToken cancellationToken)
    {
        var franchiseId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        var mediasIds = await _mediaRepository.GetPrimaryIdsByBusinessIdsAsync(request.MediaIds);

        if (mediasIds.Count != request.MediaIds.Count)
        {
            throw new NotFoundException("One or more medias were not found.");
        }

        await _franchiseRepository.UpdateMedias(franchiseId, mediasIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}