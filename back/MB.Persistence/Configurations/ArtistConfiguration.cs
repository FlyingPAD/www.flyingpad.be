using MB.Domain.ArtistAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();

        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasData(
            new Artist { EntityId = 1, BusinessId = Guid.Parse("aaaaaaaa-bbbb-cccc-dddd-000000000001"), Name = "# Unknown Artist" }
        );
    }
}