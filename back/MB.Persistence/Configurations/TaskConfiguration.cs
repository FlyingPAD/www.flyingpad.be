using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configuration;

public class TaskConfiguration : IEntityTypeConfiguration<MB.Domain.Entities.Task>
{
    public void Configure(EntityTypeBuilder<MB.Domain.Entities.Task> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .HasDefaultValue(DateTime.Now);

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
