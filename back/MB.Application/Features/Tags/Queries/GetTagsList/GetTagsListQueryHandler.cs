using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Tags.Queries.GetTagsList
{
    public class GetTagsListQueryHandler : IRequestHandler<GetTagsListQuery, GetTagsListQueryResponse>
    {
        private readonly IBaseRepository<Tag> _tagRepository;
        private readonly IMapper _mapper;

        public GetTagsListQueryHandler(IBaseRepository<Tag> tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        public async Task<GetTagsListQueryResponse> Handle(GetTagsListQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var tags = await _tagRepository.GetAllAsync();
                var response = new GetTagsListQueryResponse
                {
                    Success = true,
                    Message = "Here are the Tags !",
                    TagsList = _mapper.Map<List<TagListVm>>(tags)
                };

                return response;
            }
            catch (Exception ex)
            {
                // Gérez l'exception et renvoyez une réponse d'erreur
                var response = new GetTagsListQueryResponse
                {
                    Success = false,
                    ValidationErrors = new List<string> { $"Une erreur s'est produite ( {ex} )." }
                };

                return response;
            }
        }
    }
}
