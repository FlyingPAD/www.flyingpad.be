namespace MB.Application.Features.Users.Queries.GetUserById;

public class GetUserByIdQueryResponse : BaseResponse
{
    public GetUserByIdQueryDto User { get; set; } = default!;
}