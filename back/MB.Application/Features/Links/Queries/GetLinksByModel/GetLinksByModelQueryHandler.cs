using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Application.Interfaces.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Links.Queries.GetLinksByModel
{
    public class GetLinksByModelQueryHandler(ILinkRepository linkRepository, IBaseRepository<Model> modelRepository, IMapper mapper) : IRequestHandler<GetLinksByModelQuery, GetLinksByModelQueryResponse>
    {
        private readonly ILinkRepository _linkRepository = linkRepository;
        private readonly IBaseRepository<Model> _modelRepository = modelRepository;
        private readonly IMapper _mapper = mapper;

        public async Task<GetLinksByModelQueryResponse> Handle(GetLinksByModelQuery request, CancellationToken cancellationToken)
        {
            int modelId = await _modelRepository.GetPrimaryIdByBusinessIdAsync(request.ModelId)
                ?? throw new NotFoundException("Model not found.");

            var links = await _linkRepository.GetLinksByModel(modelId);

            return new GetLinksByModelQueryResponse
            {
                Success = true,
                Message = "Related Links.",
                Links = _mapper.Map<List<GetLinksByModelQueryDto>>(links)
            };
        }
    }
}