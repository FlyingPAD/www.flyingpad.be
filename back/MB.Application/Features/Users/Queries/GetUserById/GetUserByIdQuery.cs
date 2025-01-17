using MediatR;

namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQuery : IRequest<GetUserByIdQueryResponse>
{
    public Guid UserId { get; set; }
}