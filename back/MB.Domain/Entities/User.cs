using MB.Domain.Common;

namespace MB.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; } = DateTime.MinValue;
        public string Email { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; } = [];
        public byte[]? PasswordSalt { get; set; } = [];
        public int Role { get; set; } = 1;
    }
}