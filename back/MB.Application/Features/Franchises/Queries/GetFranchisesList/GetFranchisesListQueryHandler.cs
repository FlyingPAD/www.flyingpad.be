using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesList
{
    public class GetFranchisesListQueryHandler(IBaseRepository<Franchise> franchiseRepository, IBaseRepository<Media> mediaRepository, IBaseRepository<Model> modelRepository, IMapper mapper) : IRequestHandler<GetFranchisesListQuery, GetFranchisesListQueryResponse>
    {
        private readonly IBaseRepository<Media> _mediaRepository = mediaRepository;
        private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;
        private readonly IBaseRepository<Model> _modelRepository = modelRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<GetFranchisesListQueryResponse> Handle(GetFranchisesListQuery request, CancellationToken cancellationToken)
        {
            var medias = await _mediaRepository.GetAllAsync();

            foreach (var media in medias) 
            {
                var franchises = await _franchiseRepository.GetAllAsync();

                media.
            }

            

            var response = new GetFranchisesListQueryResponse
            {
                Success = true,
                Message = "Here are the Franchises !",
                Medias = _mapper.Map<List<GFLQMediaDto>>(medias)
            };

            return response;
        }
    }
}
