using AutoMapper;
using MB.Application.Contracts.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia;

public class GetFranchisesByMediaQueryHandler(IMapper mapper, IMediaRepository mediaRepo,IFranchiseRepository franchiseRepo, GetFranchisesByMediaQueryValidator validator) : IRequestHandler<GetFranchisesByMediaQuery, GetFranchisesByMediaQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepo = franchiseRepo;
    private readonly IMediaRepository _mediaRepo = mediaRepo;
    private readonly GetFranchisesByMediaQueryValidator _validator = validator;

    public async Task<GetFranchisesByMediaQueryResponse> Handle(GetFranchisesByMediaQuery request, CancellationToken cancellationToken)
    {
        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if (validationResult.Errors.Count > 0)
        {
            return new GetFranchisesByMediaQueryResponse
            {
                Message = "Error(s)...",
                ValidationErrors = validationResult.Errors.Select(error => error.ErrorMessage).ToList()
            };
        }

        int? mediaId = await _mediaRepo.GetPrimaryIdByBusinessIdAsync(request.MediaId);
        var franchises = await _franchiseRepo.GetFranchisesByMedia(mediaId);

        var response = new GetFranchisesByMediaQueryResponse
        {
            Success = true,
            Message = "",
            ValidationErrors = [],
            Franchises = _mapper.Map<List<GetFranchisesByMediaQueryVm>>(franchises)
        };

        return response;
    }
}