using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.AchievementAggregate;

namespace MB.Persistence.Configurations;

public class AchievementDefinitionConfiguration : IEntityTypeConfiguration<AchievementDefinition>
{
    public void Configure(EntityTypeBuilder<AchievementDefinition> builder)
    {
        builder.ToTable("AchievementDefinitions");
        builder.HasKey(a => a.EntityId);
        builder.Property(a => a.Title).IsRequired().HasMaxLength(100);
        builder.Property(a => a.Goal).IsRequired();
        builder.Property(a => a.DoneMessage).IsRequired();
        builder.Property(a => a.Category).IsRequired().HasMaxLength(50);
        builder.Property(a => a.XpReward).IsRequired();
        builder.Property(a => a.IconUrl).HasMaxLength(200);

        builder.HasData(
            // — Standard achievements —
            new AchievementDefinition("Official Member", "Create an account", "You created an account :)", "standard", 50)
            { EntityId = 1, BusinessId = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
            new AchievementDefinition("Email Verified", "Verify your email address", "Your email is verified!", "standard", 50)
            { EntityId = 17, BusinessId = Guid.Parse("9c2f1e4a-3d7b-4f8c-9a07-1b2c3d4e5f60") },
            new AchievementDefinition("Profile Completed", "Complete your profile (add name, birthdate, avatar)", "Your profile is complete!", "standard", 75)
            { EntityId = 18, BusinessId = Guid.Parse("ac5f6d7b-8c9d-4e0f-1a2b-3c4d5e6f7a8b") },

            // — Note-master achievements —
            new AchievementDefinition("Novice (bass)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 2, BusinessId = Guid.Parse("b1e2c3d4-f5a6-7b8c-9d0e-1f2a3b4c5d6e") },
            new AchievementDefinition("Intermediate (bass)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 3, BusinessId = Guid.Parse("c2d3e4f5-a6b7-8c9d-0e1f-2a3b4c5d6e7f") },
            new AchievementDefinition("Advanced (bass)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 4, BusinessId = Guid.Parse("d3e4f5a6-b7c8-9d0e-1f2a-3b4c5d6e7f80") },
            new AchievementDefinition("Expert (bass)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 5, BusinessId = Guid.Parse("e4f5a6b7-c8d9-0e1f-2a3b-4c5d6e7f8091") },
            new AchievementDefinition("Master (bass)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 6, BusinessId = Guid.Parse("f5a6b7c8-d9e0-1f2a-3b4c-5d6e7f8091a2") },

            new AchievementDefinition("Novice (alto)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 7, BusinessId = Guid.Parse("a6b7c8d9-e0f1-2a3b-4c5d-6e7f8091a2b3") },
            new AchievementDefinition("Intermediate (alto)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 8, BusinessId = Guid.Parse("b7c8d9e0-f1a2-3b4c-5d6e-7f8091a2b3c4") },
            new AchievementDefinition("Advanced (alto)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 9, BusinessId = Guid.Parse("c8d9e0f1-a2b3-4c5d-6e7f-8091a2b3c4d5") },
            new AchievementDefinition("Expert (alto)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 10, BusinessId = Guid.Parse("d9e0f1a2-b3c4-5d6e-7f80-91a2b3c4d5e6") },
            new AchievementDefinition("Master (alto)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 11, BusinessId = Guid.Parse("e0f1a2b3-c4d5-6e7f-8091-a2b3c4d5e6f7") },

            new AchievementDefinition("Novice (treble)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 12, BusinessId = Guid.Parse("f1a2b3c4-d5e6-7f80-91a2-b3c4d5e6f7a8") },
            new AchievementDefinition("Intermediate (treble)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 13, BusinessId = Guid.Parse("a2b3c4d5-e6f7-8091-a2b3-c4d5e6f7a8b9") },
            new AchievementDefinition("Advanced (treble)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 14, BusinessId = Guid.Parse("b3c4d5e6-f7a8-091a-2b3c-4d5e6f7a8b9c") },
            new AchievementDefinition("Expert (treble)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 15, BusinessId = Guid.Parse("c4d5e6f7-a8b9-0a1b-3c4d-5e6f7a8b9c0d") },
            new AchievementDefinition("Master (treble)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 16, BusinessId = Guid.Parse("d5e6f7a8-b9c0-1a2b-3c4d-5e6f7a8b9c0d") },

            // — Level achievements —
            new AchievementDefinition("Level 2 Achieved", "Reach level 2", "You reached level 2!", "level", 100)
            { EntityId = 19, BusinessId = Guid.Parse("e6f7a8b9-c0d1-2a3b-4c5d-6e7f8091a2b3") },
            new AchievementDefinition("Level 3 Achieved", "Reach level 3", "You reached level 3!", "level", 150)
            { EntityId = 20, BusinessId = Guid.Parse("f7a8b9c0-d1e2-3a4b-5c6d-7e8f9012a3b4") },
            new AchievementDefinition("Level 4 Achieved", "Reach level 4", "You reached level 4!", "level", 200)
            { EntityId = 21, BusinessId = Guid.Parse("a8b9c0d1-e2f3-4a5b-6c7d-8e9f0123b4c5") },
            new AchievementDefinition("Level 5 Achieved", "Reach level 5", "You reached level 5!", "level", 250)
            { EntityId = 22, BusinessId = Guid.Parse("b9c0d1e2-f3a4-5b6c-7d8e-9f0123b4c5d6") },
            new AchievementDefinition("Level 6 Achieved", "Reach level 6", "You reached level 6!", "level", 300)
            { EntityId = 23, BusinessId = Guid.Parse("c0d1e2f3-a4b5-6c7d-8e9f-0123b4c5d6e7") },
            new AchievementDefinition("Level 7 Achieved", "Reach level 7", "You reached level 7!", "level", 350)
            { EntityId = 24, BusinessId = Guid.Parse("d1e2f3a4-b5c6-7d8e-9f01-234b5c6d7e8f") },

            // — League achievements —
            new AchievementDefinition("Wood League", "Be promoted to Wood league", "You’re now in Wood league!", "league", 50)
            { EntityId = 25, BusinessId = Guid.Parse("e2f3a4b5-c6d7-8e9f-0123-4b5c6d7e8f90") },
            new AchievementDefinition("Stone League", "Be promoted to Stone league", "You’re now in Stone league!", "league", 100)
            { EntityId = 26, BusinessId = Guid.Parse("f3a4b5c6-d7e8-9f01-2345-c6d7e8f901a2") },
            new AchievementDefinition("Bronze League", "Be promoted to Bronze league", "You’re now in Bronze league!", "league", 150)
            { EntityId = 27, BusinessId = Guid.Parse("a4b5c6d7-e8f9-0123-4567-d7e8f901a2b3") },
            new AchievementDefinition("Silver League", "Be promoted to Silver league", "You’re now in Silver league!", "league", 200)
            { EntityId = 28, BusinessId = Guid.Parse("b5c6d7e8-f901-2345-6789-e8f901a2b3c4") },
            new AchievementDefinition("Crystal League", "Be promoted to Crystal league", "You’re now in Crystal league!", "league", 250)
            { EntityId = 29, BusinessId = Guid.Parse("c6d7e8f9-0123-4567-89a0-f901a2b3c4d5") },
            new AchievementDefinition("Elite League", "Be promoted to Elite league", "You’re now in Elite league!", "league", 300)
            { EntityId = 30, BusinessId = Guid.Parse("d7e8f901-2345-6789-a0b1-0123c4d5e6f7") },
            new AchievementDefinition("Champion League", "Be promoted to Champion league", "You’re now in Champion league!", "league", 350)
            { EntityId = 31, BusinessId = Guid.Parse("e8f901a2-3456-789a-0b1c-1234d5e6f7a8") },
            new AchievementDefinition("Legend League", "Be promoted to Legend league", "You’re now in Legend league!", "league", 400)
            { EntityId = 32, BusinessId = Guid.Parse("f901a2b3-4567-89a0-b1c2-2345e6f7a8b9") }
        );
    }
}