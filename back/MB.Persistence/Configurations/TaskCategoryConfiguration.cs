using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.TaskCategoryAggregate;

namespace MB.Persistence.Configurations;

public class TaskCategoryConfiguration : IEntityTypeConfiguration<TaskCategory>
{
    public void Configure(EntityTypeBuilder<TaskCategory> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
