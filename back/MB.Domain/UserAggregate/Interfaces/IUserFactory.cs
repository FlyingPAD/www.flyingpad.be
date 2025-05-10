namespace MB.Domain.UserAggregate.Interfaces
{
    public interface IUserFactory
    {
        User Create(
            string userName,
            string firstName,
            string lastName,
            string email,
            string plainPassword,
            DateTime birthdate);
    }
}