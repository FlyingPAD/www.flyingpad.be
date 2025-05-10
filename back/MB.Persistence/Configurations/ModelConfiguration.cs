using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.ModelAggregate;

namespace MB.Persistence.Configurations;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(entity => entity.LastName)
            .HasMaxLength(50);
    }
}