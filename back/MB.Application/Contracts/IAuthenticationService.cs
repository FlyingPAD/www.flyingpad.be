namespace MB.Application.Contracts
{
    public interface IAuthentificationService
    {
        Task<string> GetAccessToken(CancellationToken cancellationToken);
    }
}
