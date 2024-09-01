using MB.Application.Contracts.Persistence;
using MB.Application.Models;
using MediatR;

namespace MB.Application.Features.Relations.Commands.CreateRelationsFranchiseMedia;

public class CreateRelationsFranchiseMediaCommandHandler : IRequestHandler<CreateRelationsFranchiseMediaCommand, BaseResponse>
{
    private readonly IFranchiseRepository _franchiseRepository;
    private readonly IMediaRepository _mediaRepository;
    private readonly CreateRelationsFranchiseMediaCommandValidator _validator;

    public CreateRelationsFranchiseMediaCommandHandler(IFranchiseRepository franchiseRepository, IMediaRepository mediaRepository, CreateRelationsFranchiseMediaCommandValidator validator)
    {
        _franchiseRepository = franchiseRepository;
        _mediaRepository = mediaRepository;
        _validator = validator;
    }

    public async Task<BaseResponse> Handle(CreateRelationsFranchiseMediaCommand request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count > 0)
        {
            return new BaseResponse
            {
                Success = false,
                Message = "Validation Error(s)",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

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