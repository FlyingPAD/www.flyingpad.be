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
        var franchisePrimaryId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId);

        if (franchisePrimaryId == null)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Franchise was not found."
            };
        }

        var mediasPrimaryIds = await _mediaRepository.GetPrimaryIdsByBusinessIdsAsync(request.MediaIds);

        if (mediasPrimaryIds.Count != request.MediaIds.Count)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "One or more medias were not found."
            };
        }

        await _franchiseRepository.UpdateMedias((int)franchisePrimaryId, mediasPrimaryIds);

        return new BaseResponse
        {
            Success = true,
            Message = "Relations created successfully."
        };
    }
}