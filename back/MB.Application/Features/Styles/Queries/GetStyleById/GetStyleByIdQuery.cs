using MediatR;

namespace MB.Application.Features.Styles.Queries.GetStyleById;

public class GetStyleByIdQuery : IRequest<GetStyleByIdQueryResponse>
{
    public Guid StyleId { get; set; }
}