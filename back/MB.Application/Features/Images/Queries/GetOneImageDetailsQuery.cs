using MediatR;

namespace MB.Application.Features.Images.Queries
{
    public class GetOneImageDetailsQuery : IRequest<GetOneImageDetailsQueryResponse>
    {
        public Guid ImageId { get; set; }
    }
}