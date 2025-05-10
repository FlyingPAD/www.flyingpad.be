using MB.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class EmailVerificationTokenConfiguration : IEntityTypeConfiguration<EmailVerificationToken>
{
    public void Configure(EntityTypeBuilder<EmailVerificationToken> builder)
    {
        builder.HasKey(t => t.TokenId);

        builder
            .Property(t => t.Token)
            .IsRequired()
            .HasMaxLength(128);

        builder
            .Property(t => t.ExpiresAt)
            .IsRequired();
        builder
            .Property(t => t.CreatedAt)
            .IsRequired();

        builder
            .HasOne(t => t.User)
            .WithMany(u => u.EmailVerificationTokens)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasIndex(t => t.Token)
            .IsUnique();
        builder
            .HasIndex(t => t.ExpiresAt);
    }
}