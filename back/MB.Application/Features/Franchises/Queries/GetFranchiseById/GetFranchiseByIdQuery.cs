using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchiseById
{
    public class GetFranchiseByIdQuery : IRequest<GetFranchiseByIdQueryResponse>
    {
        public Guid BusinessId { get; set; } = Guid.Empty;
    }
}

