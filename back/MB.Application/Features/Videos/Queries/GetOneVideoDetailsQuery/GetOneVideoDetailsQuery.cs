using MediatR;

namespace MB.Application.Features.Videos.Queries.GetOneVideoDetailsQuery
{
    public class GetOneVideoDetailsQuery : IRequest<GetOneVideoDetailsQueryResponse>
    {
        public Guid VideoId { get; set; }
    }
}