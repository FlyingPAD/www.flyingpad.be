using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediaCheckBoxesByFranchise
{
    public class GetMediaCheckBoxesByFranchiseQuery : IRequest<GetMediaCheckBoxesByFranchiseQueryResponse>
    {
        public Guid FranchiseId { get; set; }
    }
}