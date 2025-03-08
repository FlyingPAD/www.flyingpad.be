using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<Domain.TaskAggregate.Task>
{
    public void Configure(EntityTypeBuilder<Domain.TaskAggregate.Task> builder)
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
