using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.MoodAggregate;

namespace MB.Persistence.Configurations;

public class MoodConfiguration : IEntityTypeConfiguration<Mood>
{
    public void Configure(EntityTypeBuilder<Mood> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
