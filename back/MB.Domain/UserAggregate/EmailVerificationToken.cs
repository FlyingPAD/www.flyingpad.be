namespace MB.Domain.UserAggregate;

public class EmailVerificationToken
{
    public Guid TokenId { get; set; } = Guid.NewGuid();
    public int UserId { get; set; }
    public string Token { get; set; } = null!;
    public DateTimeOffset ExpiresAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    // Navigation
    public User User { get; set; } = null!;
}