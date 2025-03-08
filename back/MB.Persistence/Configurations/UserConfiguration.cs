using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.UserAggregate;

namespace MB.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.UserName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(entity => entity.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(entity => entity.LastName)
            .IsRequired()
            .HasMaxLength(50);
    }
}