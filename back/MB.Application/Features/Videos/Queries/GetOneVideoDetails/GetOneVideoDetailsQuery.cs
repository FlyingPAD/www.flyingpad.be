using MediatR;

namespace MB.Application.Features.Videos.Queries.GetOneVideoDetails;

public class GetOneVideoDetailsQuery : IRequest<GetOneVideoDetailsQueryResponse>
{
    public Guid VideoId { get; set; }
}