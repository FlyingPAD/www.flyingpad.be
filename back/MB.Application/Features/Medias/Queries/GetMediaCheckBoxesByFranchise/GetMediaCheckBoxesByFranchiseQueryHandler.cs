using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediaCheckBoxesByFranchise
{
    public class GetMediaCheckBoxesByFranchiseQueryHandler(IMapper mapper, IFranchiseRepository franchiseRepository, IMediaRepository mediaRepository) : IRequestHandler<GetMediaCheckBoxesByFranchiseQuery, GetMediaCheckBoxesByFranchiseQueryResponse>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
        private readonly IMediaRepository _mediaRepository = mediaRepository;

        public async Task<GetMediaCheckBoxesByFranchiseQueryResponse> Handle(GetMediaCheckBoxesByFranchiseQuery request, CancellationToken cancellationToken)
        {
            int franchiseId = await _franchiseRepository.GetPrimaryIdByBusinessIdAsync(request.FranchiseId)
                ?? throw new NotFoundException("Franchise not found.");

            var media = await _mediaRepository.GetCheckBoxesByFranchise(franchiseId);

            return new GetMediaCheckBoxesByFranchiseQueryResponse
            {
                Success = true,
                Message = "Franchise checkboxes loaded.",
                Media = _mapper.Map<GetMediaCheckBoxesByFranchiseQueryDto[]>(media)
            };
        }
    }
}