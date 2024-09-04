using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia;

public class GetFranchisesByMediaQueryHandler(IMapper mapper, IMediaRepository mediaRepo,IFranchiseRepository franchiseRepo) : IRequestHandler<GetFranchisesByMediaQuery, GetFranchisesByMediaQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepo = franchiseRepo;
    private readonly IMediaRepository _mediaRepo = mediaRepo;

    public async Task<GetFranchisesByMediaQueryResponse> Handle(GetFranchisesByMediaQuery request, CancellationToken cancellationToken)
    {
        int? mediaId = await _mediaRepo.GetPrimaryIdByBusinessIdAsync(request.MediaId);
        var franchises = await _franchiseRepo.GetFranchisesByMedia(mediaId);

        var response = new GetFranchisesByMediaQueryResponse
        {
            Success = true,
            Message = "Success.",
            Franchises = _mapper.Map<List<GetFranchisesByMediaQueryVm>>(franchises)
        };

        return response;
    }
}