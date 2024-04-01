using AutoMapper;
using MB.Application.Contracts.Persistence.Common;
using MB.Domain.Entities;
using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStyleById
{
    public class GetStyleByIdQueryHandler : IRequestHandler<GetStyleByIdQuery, GetStyleByIdQueryResponse>
    {
        private readonly IMapper _mapper;
        private IBaseRepository<Style> _styleRepository;

        public GetStyleByIdQueryHandler(IMapper mapper, IBaseRepository<Style> styleRepository)
        {
            _mapper = mapper;
            _styleRepository = styleRepository;
        }

        public async Task<GetStyleByIdQueryResponse> Handle(GetStyleByIdQuery request, CancellationToken cancellationToken)
        {
            var style = await _styleRepository.GetByBusinessIdAsync(request.Id);

            if (style == null)
            {
                return new GetStyleByIdQueryResponse { Success = false, Message = "Style wasn't found :(" };
            }

            var styleDto = _mapper.Map<GetStyleByIdVm>(style);

            return new GetStyleByIdQueryResponse
            {
                Success = true,
                Message = "Style was found :)",
                Style = styleDto
            };
        }
    }
}