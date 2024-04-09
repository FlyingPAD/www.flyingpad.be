using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesByMedia
{
    public class GetFranchisesByMediaQuery : IRequest<GetFranchisesByMediaQueryResponse>
    {
        public Guid MediaId { get; set; }
    }
}
