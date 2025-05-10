using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.LevelAggregate;

namespace MB.Persistence.Configurations;

public class LevelDefinitionConfiguration : IEntityTypeConfiguration<LevelDefinition>
{
    public void Configure(EntityTypeBuilder<LevelDefinition> builder)
    {
        builder.ToTable("LevelDefinitions");
        builder.HasKey(ld => ld.EntityId);
        builder.Property(ld => ld.LevelNumber).IsRequired();
        builder.Property(ld => ld.MinExperience).IsRequired();
        builder.Property(ld => ld.MaxExperience).IsRequired(false);

        builder.HasData(
            new LevelDefinition(levelNumber: 1, minExp: 0, maxExp: 99) { EntityId = 1, BusinessId = Guid.Parse("3f1e2d4c-5b6a-7d8c-9e0f-1a2b3c4d5e6f") },
            new LevelDefinition(levelNumber: 2, minExp: 100, maxExp: 199) { EntityId = 2, BusinessId = Guid.Parse("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d") },
            new LevelDefinition(levelNumber: 3, minExp: 200, maxExp: 399) { EntityId = 3, BusinessId = Guid.Parse("12345678-9abc-def0-1234-56789abcdef0") },
            new LevelDefinition(levelNumber: 4, minExp: 400, maxExp: 699) { EntityId = 4, BusinessId = Guid.Parse("0fedcba9-8765-4321-0fed-cba987654321") },
            new LevelDefinition(levelNumber: 5, minExp: 700, maxExp: 999) { EntityId = 5, BusinessId = Guid.Parse("abcdef01-2345-6789-abcd-ef0123456789") },
            new LevelDefinition(levelNumber: 6, minExp: 1000, maxExp: null) { EntityId = 6, BusinessId = Guid.Parse("09876543-21fe-dcba-9876-54321fedcba0") }
        );
    }
}