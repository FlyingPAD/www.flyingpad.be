using MB.Domain.LevelAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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
            new LevelDefinition(levelNumber: 1, minExp: 0, maxExp: 281) { EntityId = 1, BusinessId = Guid.Parse("a3f1e23c-b7d6-4f8a-9e0f-123456789abc") },
            new LevelDefinition(levelNumber: 2, minExp: 282, maxExp: 518) { EntityId = 2, BusinessId = Guid.Parse("b2e1c4d5-e6f7-0a1b-2c3d-4e5f6789abcd") },
            new LevelDefinition(levelNumber: 3, minExp: 519, maxExp: 799) { EntityId = 3, BusinessId = Guid.Parse("c3d2e1f4-a5b6-7c8d-9e0f-abcdef012345") },
            new LevelDefinition(levelNumber: 4, minExp: 800, maxExp: 1117) { EntityId = 4, BusinessId = Guid.Parse("d4e3f2a1-b6c5-8d7e-0f9a-1234bcdef567") },
            new LevelDefinition(levelNumber: 5, minExp: 1118, maxExp: 1468) { EntityId = 5, BusinessId = Guid.Parse("e5f4a3b2-c1d0-9e8f-7d6c-5b4a3c2d1e0f") },
            new LevelDefinition(levelNumber: 6, minExp: 1469, maxExp: 1850) { EntityId = 6, BusinessId = Guid.Parse("f6a5b4c3-d2e1-0f9a-8b7c-6d5e4f3a2b1c") },
            new LevelDefinition(levelNumber: 7, minExp: 1851, maxExp: 2261) { EntityId = 7, BusinessId = Guid.Parse("07b6c5d4-e3f2-1a0b-9c8d-7e6f5a4b3c2d") },
            new LevelDefinition(levelNumber: 8, minExp: 2262, maxExp: 2698) { EntityId = 8, BusinessId = Guid.Parse("18c7d6e5-f4a3-2b1c-8d7e-9f8a7b6c5d4e") },
            new LevelDefinition(levelNumber: 9, minExp: 2699, maxExp: 3160) { EntityId = 9, BusinessId = Guid.Parse("29d8e7f6-a5b4-3c2d-7e8f-0a9b8c7d6e5f") },
            new LevelDefinition(levelNumber: 10, minExp: 3161, maxExp: 3646) { EntityId = 10, BusinessId = Guid.Parse("30e9f8a7-b6c5-4d3e-6f7a-1b2c3d4e5f6a") },
            new LevelDefinition(levelNumber: 11, minExp: 3647, maxExp: 4155) { EntityId = 11, BusinessId = Guid.Parse("41f0a9b8-c7d6-5e4f-7a8b-2c3d4e5f6a7b") },
            new LevelDefinition(levelNumber: 12, minExp: 4156, maxExp: 4685) { EntityId = 12, BusinessId = Guid.Parse("52a1b0c9-d8e7-6f5a-8b9c-3d4e5f6a7b8c") },
            new LevelDefinition(levelNumber: 13, minExp: 4686, maxExp: 5236) { EntityId = 13, BusinessId = Guid.Parse("63b2c1d0-e9f8-7a6b-9c0d-4e5f6a7b8c9d") },
            new LevelDefinition(levelNumber: 14, minExp: 5237, maxExp: 5807) { EntityId = 14, BusinessId = Guid.Parse("74c3d2e1-f0a9-8b7c-0d1e-5f6a7b8c9d0e") },
            new LevelDefinition(levelNumber: 15, minExp: 5808, maxExp: null) { EntityId = 15, BusinessId = Guid.Parse("85d4e3f2-a1b0-9c8d-1e2f-6a7b8c9d0e1f") }
        );
    }
}