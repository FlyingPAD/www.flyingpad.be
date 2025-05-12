using MB.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Table & clé
        builder.ToTable("Users");
        builder.HasKey(u => u.EntityId);
        builder.Property(u => u.EntityId).ValueGeneratedOnAdd();

        // Identité et contact
        builder.Property(u => u.Email).IsRequired().HasMaxLength(254);
        builder.Property(u => u.UserName).IsRequired(false).HasMaxLength(50);
        builder.Property(u => u.FirstName).IsRequired(false).HasMaxLength(50);
        builder.Property(u => u.LastName).IsRequired(false).HasMaxLength(50);

        // Authentification
        builder.Property(u => u.PasswordHash).IsRequired(false);
        builder.Property(u => u.PasswordSalt).IsRequired(false);

        // Progression
        builder.Property(u => u.Experience).IsRequired().HasDefaultValue(0);
        builder.Property(u => u.Level).IsRequired().HasDefaultValue(1);
        builder.Property(u => u.SeasonScore).IsRequired().HasDefaultValue(0);

        // Statut email
        builder.Property(u => u.IsEmailVerified).IsRequired().HasDefaultValue(false);

        // Rôles & date de naissance
        builder.Property(u => u.Role).IsRequired().HasDefaultValue(1);
        builder.Property(u => u.Birthdate).IsRequired(false);

        // Relations
        builder.HasMany(u => u.EmailVerificationTokens)
               .WithOne(t => t.User)
               .HasForeignKey(t => t.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Achievements)
               .WithOne(ua => ua.User)
               .HasForeignKey(ua => ua.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(u => u.Season)
               .WithMany()
               .HasForeignKey(u => u.SeasonId)
               .OnDelete(DeleteBehavior.SetNull);

        builder.HasOne(u => u.LeagueDefinition)
               .WithMany()
               .HasForeignKey(u => u.LeagueDefinitionId)
               .OnDelete(DeleteBehavior.SetNull);
    }
}