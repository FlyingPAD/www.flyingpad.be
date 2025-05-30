using AutoMapper;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Definitions;
using MB.Domain.MediumAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList;

public class GetFranchisesListQueryHandler(IBaseRepository<Media> mediaRepository, IFranchiseRepository franchiseRepository, IModelRepository modelRepository, IMapper mapper) : IRequestHandler<GetFranchisesListQuery, GetFranchisesListQueryResponse>
{
    private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;
    private readonly IFranchiseRepository _franchiseRepository = franchiseRepository;
    private readonly IModelRepository _modelRepository = modelRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GetFranchisesListQueryResponse> Handle(GetFranchisesListQuery request, CancellationToken cancellationToken)
    {
        var mediasQuery = await _mediaRepository.GetAllAsync(media => media.Name);
        var medias = await mediasQuery.ToListAsync(cancellationToken);
        var mediasListDto = new List<GFLQMediaDto>();

        foreach (var media in medias)
        {
            var franchises = await _franchiseRepository.GetFranchisesByMedia(media.EntityId);

            var franchisesListDto = new List<GFLQFranchiseDto>();

            foreach (var franchise in franchises)
            {
                var models = await _modelRepository.GetModelsByFranchise(franchise.EntityId);

                var franchiseDto = _mapper.Map<GFLQFranchiseDto>(franchise);
                franchiseDto.Models = _mapper.Map<List<GFLQModelDto>>(models);

                franchisesListDto.Add(franchiseDto);
            }

            var mediaDto = _mapper.Map<GFLQMediaDto>(media);
            mediaDto.Franchises = franchisesListDto;

            mediasListDto.Add(mediaDto);
        }

        return new GetFranchisesListQueryResponse
        {
            Success = true,
            Message = "Media full list was loaded.",
            Media = mediasListDto
        };
    }
}