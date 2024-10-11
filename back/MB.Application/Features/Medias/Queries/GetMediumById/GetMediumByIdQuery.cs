using MediatR;

namespace MB.Application.Features.Medias.Queries.GetMediumById;

public class GetMediumByIdQuery : IRequest<GetMediumByIdQueryResponse>
{
    public Guid MediumId { get; set; }
}