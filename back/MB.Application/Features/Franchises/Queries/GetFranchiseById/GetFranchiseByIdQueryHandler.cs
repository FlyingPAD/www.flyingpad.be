using AutoMapper;
using MB.Application.Exceptions;
using MB.Application.Interfaces.Persistence;
using MB.Domain.FranchiseAggregate;
using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById;

public class GetFranchiseByIdQueryHandler(IMapper mapper, IBaseRepository<Franchise> franchiseRepository) : IRequestHandler<GetFranchiseByIdQuery, GetFranchiseByIdQueryResponse>
{
    private readonly IMapper _mapper = mapper;
    private readonly IBaseRepository<Franchise> _franchiseRepository = franchiseRepository;

    public async Task<GetFranchiseByIdQueryResponse> Handle(GetFranchiseByIdQuery request, CancellationToken cancellationToken)
    {
        var franchise = await _franchiseRepository.GetByBusinessIdAsync(request.FranchiseId)
            ?? throw new NotFoundException("Franchise not found.");

        return new GetFranchiseByIdQueryResponse
        {
            Success = true,
            Message = $"{franchise.Name}.",
            Franchise = _mapper.Map<GetFranchiseByIdQueryDto>(franchise)
        };
    }
}