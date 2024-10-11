using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedium;

public class GetFranchisesByMediumQueryHandler(IMapper mapper, IMediaRepository mediaRepo,IFranchiseRepository franchiseRepo) : IRequestHandler<GetFranchisesByMediumQuery, GetFranchisesByMediumQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IFranchiseRepository _franchiseRepo = franchiseRepo;
    private readonly IMediaRepository _mediaRepo = mediaRepo;

    public async Task<GetFranchisesByMediumQueryResponse> Handle(GetFranchisesByMediumQuery request, CancellationToken cancellationToken)
    {
        int mediumId = await _mediaRepo.GetPrimaryIdByBusinessIdAsync(request.MediumId)
            ?? throw new NotFoundException("Medium not found.");

        var franchises = await _franchiseRepo.GetFranchisesByMedia(mediumId);

        return new GetFranchisesByMediumQueryResponse
        {
            Success = true,
            Message = "Franchises by medium.",
            Franchises = _mapper.Map<List<GetFranchisesByMediumQueryDto>>(franchises)
        };
    }
}