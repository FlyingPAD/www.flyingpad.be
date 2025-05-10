using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.LeagueAggregate;

namespace MB.Persistence.Configurations;

public class LeagueDefinitionConfiguration : IEntityTypeConfiguration<LeagueDefinition>
{
    public void Configure(EntityTypeBuilder<LeagueDefinition> builder)
    {
        builder.ToTable("LeagueDefinitions");
        builder.HasKey(l => l.EntityId);
        builder.Property(l => l.Name).IsRequired().HasMaxLength(50);
        builder.Property(l => l.MinExperience).IsRequired();
        builder.Property(l => l.MaxExperience).IsRequired(false);
        builder.Property(l => l.Order).IsRequired();
        builder.Property(l => l.IconCssClass).HasMaxLength(100);
        builder.HasOne(l => l.Season)
               .WithMany()
               .HasForeignKey(l => l.SeasonId)
               .OnDelete(DeleteBehavior.SetNull);

        builder.HasData(
            new LeagueDefinition("Wood", minExp: 0, maxExp: 99, order: 1, iconCss: "league-wood") { EntityId = 1, BusinessId = Guid.Parse("a12f4d56-3b78-4c9e-9a1d-2e3f4b5c6d7e") },
            new LeagueDefinition("Stone", minExp: 100, maxExp: 199, order: 2, iconCss: "league-stone") { EntityId = 2, BusinessId = Guid.Parse("b23e5c67-4c89-5daf-0b2e-3f4a5c6d7e8f") },
            new LeagueDefinition("Bronze", minExp: 200, maxExp: 299, order: 3, iconCss: "league-bronze") { EntityId = 3, BusinessId = Guid.Parse("c34f6d78-5da0-6ebf-1c3f-4a5b6c7d8e9f") },
            new LeagueDefinition("Silver", minExp: 300, maxExp: 399, order: 4, iconCss: "league-silver") { EntityId = 4, BusinessId = Guid.Parse("d45a7e89-6eb1-7fc0-2d4f-5b6c7d8e9f0a") },
            new LeagueDefinition("Crystal", minExp: 400, maxExp: 499, order: 5, iconCss: "league-crystal") { EntityId = 5, BusinessId = Guid.Parse("e56b8f9a-7fc2-8ad1-3e5f-6c7d8e9f0a1b") },
            new LeagueDefinition("Elite", minExp: 500, maxExp: 599, order: 6, iconCss: "league-elite") { EntityId = 6, BusinessId = Guid.Parse("f67c9fab-8ad3-9be2-4f6f-7d8e9f0a1b2c") },
            new LeagueDefinition("Champion", minExp: 600, maxExp: 699, order: 7, iconCss: "league-champion") { EntityId = 7, BusinessId = Guid.Parse("a78d0abc-9be4-acf3-5f7f-8e9f0a1b2c3d") },
            new LeagueDefinition("Legend", minExp: 700, maxExp: null, order: 8, iconCss: "league-legend") { EntityId = 8, BusinessId = Guid.Parse("b89e1bcd-acf5-bd04-6f8f-9f0a1b2c3d4e") }
        );
    }
}