using MediatR;

namespace MB.Application.Features.Franchises.Queries.GetFranchisesCheckBoxesByModel
{
    public class GetFranchisesCheckBoxesByModelQuery : IRequest<GetFranchisesCheckBoxesByModelQueryResponse>
    {
        public Guid ModelId { get; set; }
    }
}