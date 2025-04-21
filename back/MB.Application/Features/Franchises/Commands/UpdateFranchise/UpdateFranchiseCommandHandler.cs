using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Commands.UpdateFranchise;

public class UpdateFranchiseCommandHandler(IFranchiseRepository franchiseRepository, IMediaRepository mediaRepository) : IRequestHandler<UpdateFranchiseCommand, BaseResponse>
{
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
    private readonly IMediaRepository _mediaRepository = mediaRepository;

    public async Task<BaseResponse> Handle(UpdateFranchiseCommand request, CancellationToken cancellationToken)
    {
        var franchiseId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        var franchise = await _franchiseRepository.GetFranchiseWithMediaAsync(franchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        franchise.Name = request.Name;
        franchise.Description = request.Description;

        await _franchiseRepository.UpdateAsync(franchise);

        await _franchiseRepository.RemoveMediaAsync(franchise);

        var mediaIds = await _mediaRepository.GetPrimaryIdsByBusinessIdsAsync(request.MediaIds);

        if (mediaIds.Count != request.MediaIds.Count)
        {
            throw new NotFoundException("One or more media were not found.");
        }

        await _franchiseRepository.AddMediaAsync(franchiseId, mediaIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Franchise was updated."
        };
    }
}