using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediasList
{
    public class GetMediasListQueryHandler : IRequestHandler<GetMediasListQuery, GetMediasListQueryResponse>
    {
        private readonly IBaseRepository<Media> _mediaRepository;
        private readonly IMapper _mapper;

        public GetMediasListQueryHandler(IBaseRepository<Media> mediaRepository, IMapper mapper)
        {
            _mediaRepository = mediaRepository;
            _mapper = mapper;
        }

        public async Task<GetMediasListQueryResponse> Handle(GetMediasListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var medias = await _mediaRepository.GetAllAsync();
                var response = new GetMediasListQueryResponse
                {
                    Success = true,
                    Message = "Here are the Medias !",
                    MediasList = _mapper.Map<List<MediaListVm>>(medias)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetMediasListQueryResponse
                {
                    Success = false,
                    ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
                };

                return response;
            }
        }
    }
}
