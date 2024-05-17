using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediaById;

public class GetMediaByIdQuery : IRequest<GetMediaByIdQueryResponse>
{
    public Guid MediaId { get; set; }
}

