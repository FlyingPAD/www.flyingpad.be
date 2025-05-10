using FluentValidation;

namespace MB.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryValidator : AbstractValidator<GetAllUsersQuery>
{
    public GetAllUsersQueryValidator()
    {

    }
}