using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.AchievementAggregate;

namespace MB.Persistence.Configurations;

public class UserAchievementConfiguration : IEntityTypeConfiguration<UserAchievement>
{
    public void Configure(EntityTypeBuilder<UserAchievement> builder)
    {
        builder.ToTable("UserAchievements");

        builder.HasKey(ua => ua.EntityId);
        builder.Property(ua => ua.EntityId).ValueGeneratedOnAdd();

        builder.Property(ua => ua.UnlockedAt).IsRequired();

        builder.HasOne(ua => ua.User)
               .WithMany(u => u.Achievements)
               .HasForeignKey(ua => ua.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(ua => ua.Definition)
               .WithMany()
               .HasForeignKey(ua => ua.AchievementDefinitionId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}