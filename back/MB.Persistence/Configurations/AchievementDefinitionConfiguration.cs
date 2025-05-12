using MB.Domain.AchievementAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations;

public class AchievementDefinitionConfiguration : IEntityTypeConfiguration<AchievementDefinition>
{
    public void Configure(EntityTypeBuilder<AchievementDefinition> builder)
    {
        builder.ToTable("AchievementDefinitions");
        builder.HasKey(a => a.EntityId);

        // Clé métier
        builder.Property(a => a.Code)
               .IsRequired()
               .HasMaxLength(100);
        builder.HasIndex(a => a.Code)
               .IsUnique();

        // Affichage
        builder.Property(a => a.Title)
               .IsRequired()
               .HasMaxLength(100);
        builder.Property(a => a.Goal)
               .IsRequired();
        builder.Property(a => a.DoneMessage)
               .IsRequired();
        builder.Property(a => a.Category)
               .IsRequired()
               .HasMaxLength(50);
        builder.Property(a => a.XpReward)
               .IsRequired();
        builder.Property(a => a.IconUrl)
               .HasMaxLength(200);

        builder.HasData(
            // — Standard achievements —
            new AchievementDefinition("OfficialMember", "Official Member", "Create an account", "You created an account :)", "standard", 50)
            { EntityId = 1, BusinessId = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
            new AchievementDefinition("EmailVerified", "Email Verified", "Verify your email address", "Your email is verified!", "standard", 50)
            { EntityId = 17, BusinessId = Guid.Parse("9c2f1e4a-3d7b-4f8c-9a07-1b2c3d4e5f60") },
            new AchievementDefinition("ProfileCompleted", "Profile Completed", "Complete your profile (add name, birthdate)", "Your profile is complete!", "standard", 75)
            { EntityId = 18, BusinessId = Guid.Parse("ac5f6d7b-8c9d-4e0f-1a2b-3c4d5e6f7a8b") },

            // — Note-master achievements —
            new AchievementDefinition("NoviceBass", "Novice (bass)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 2, BusinessId = Guid.Parse("b1e2c3d4-f5a6-7b8c-9d0e-1f2a3b4c5d6e") },
            new AchievementDefinition("IntermediateBass", "Intermediate (bass)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 3, BusinessId = Guid.Parse("c2d3e4f5-a6b7-8c9d-0e1f-2a3b4c5d6e7f") },
            new AchievementDefinition("AdvancedBass", "Advanced (bass)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 4, BusinessId = Guid.Parse("d3e4f5a6-b7c8-9d0e-1a2b-3b4c5d6e7f80") },
            new AchievementDefinition("ExpertBass", "Expert (bass)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 5, BusinessId = Guid.Parse("e4f5a6b7-c8d9-0e1f-2a3b-4c5d6e7f8091") },
            new AchievementDefinition("MasterBass", "Master (bass)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 6, BusinessId = Guid.Parse("f5a6b7c8-d9e0-1f2a-3b4c-5d6e7f8091a2") },

            new AchievementDefinition("NoviceAlto", "Novice (alto)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 7, BusinessId = Guid.Parse("a6b7c8d9-e0f1-2a3b-4c5d-6e7f8091a2b3") },
            new AchievementDefinition("IntermediateAlto", "Intermediate (alto)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 8, BusinessId = Guid.Parse("b7c8d9e0-f1a2-3b4c-5d6e-7f8091a2b3c4") },
            new AchievementDefinition("AdvancedAlto", "Advanced (alto)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 9, BusinessId = Guid.Parse("c8d9e0f1-a2b3-4c5d-6e7f-8091a2b3c4d5") },
            new AchievementDefinition("ExpertAlto", "Expert (alto)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 10, BusinessId = Guid.Parse("d9e0f1a2-b3c4-5d6e-7f80-91a2b3c4d5e6") },
            new AchievementDefinition("MasterAlto", "Master (alto)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 11, BusinessId = Guid.Parse("e0f1a2b3-c4d5-6e7f-8091-a2b3c4d5e6f7") },

            new AchievementDefinition("NoviceTreble", "Novice (treble)", "Survive 10 seconds.", "You lasted 10 sec. !!", "note-master", 50)
            { EntityId = 12, BusinessId = Guid.Parse("f1a2b3c4-d5e6-7f80-91a2-b3c4d5e6f7a8") },
            new AchievementDefinition("IntermediateTreble", "Intermediate (treble)", "Survive 20 seconds.", "You lasted 20 sec. !!", "note-master", 50)
            { EntityId = 13, BusinessId = Guid.Parse("a2b3c4d5-e6f7-8091-a2b3-c4d5e6f7a8b9") },
            new AchievementDefinition("AdvancedTreble", "Advanced (treble)", "Survive 30 seconds.", "You lasted 30 sec. !!", "note-master", 50)
            { EntityId = 14, BusinessId = Guid.Parse("b3c4d5e6-f7a8-091a-2b3c-4d5e6f7a8b9c") },
            new AchievementDefinition("ExpertTreble", "Expert (treble)", "Survive 40 seconds.", "You lasted 40 sec. !!", "note-master", 50)
            { EntityId = 15, BusinessId = Guid.Parse("c4d5e6f7-a8b9-0a1b-3c4d-5e6f7a8b9c0d") },
            new AchievementDefinition("MasterTreble", "Master (treble)", "Survive 50 seconds.", "You lasted 50 sec. !!", "note-master", 50)
            { EntityId = 16, BusinessId = Guid.Parse("d5e6f7a8-b9c0-1a2b-3c4d-5e6f7a8b9c0d") },

            // — Level achievements
            new AchievementDefinition("Level2Achieved", "Level 2 Achieved", "Reach level 2", "You reached level 2!", "level", 0)
            { EntityId = 19, BusinessId = Guid.Parse("e6f7a8b9-c0d1-2a3b-4c5d-6e7f8091a2b3") },
            new AchievementDefinition("Level3Achieved", "Level 3 Achieved", "Reach level 3", "You reached level 3!", "level", 0)
            { EntityId = 20, BusinessId = Guid.Parse("f7a8b9c0-d1e2-3a4b-5c6d-7e8f9012a3b4") },
            new AchievementDefinition("Level4Achieved", "Level 4 Achieved", "Reach level 4", "You reached level 4!", "level", 0)
            { EntityId = 21, BusinessId = Guid.Parse("a8b9c0d1-e2f3-4a5b-6c7d-8e9f0123b4c5") },
            new AchievementDefinition("Level5Achieved", "Level 5 Achieved", "Reach level 5", "You reached level 5!", "level", 0)
            { EntityId = 22, BusinessId = Guid.Parse("b9c0d1e2-f3a4-5b6c-7d8e-9f0123b4c5d6") },
            new AchievementDefinition("Level6Achieved", "Level 6 Achieved", "Reach level 6", "You reached level 6!", "level", 0)
            { EntityId = 23, BusinessId = Guid.Parse("c0d1e2f3-a4b5-6c7d-8e9f-0123b4c5d6e7") },
            new AchievementDefinition("Level7Achieved", "Level 7 Achieved", "Reach level 7", "You reached level 7!", "level", 0)
            { EntityId = 24, BusinessId = Guid.Parse("d1e2f3a4-b5c6-7d8e-9f01-234b5c6d7e8f") },
            new AchievementDefinition("Level8Achieved", "Level 8 Achieved", "Reach level 8", "You reached level 8!", "level", 0)
            { EntityId = 33, BusinessId = Guid.Parse("e2a3b4c5-d6e7-8f90-1a2b-3c4d5e6f7a8b") },
            new AchievementDefinition("Level9Achieved", "Level 9 Achieved", "Reach level 9", "You reached level 9!", "level", 0)
            { EntityId = 34, BusinessId = Guid.Parse("f3b4c5d6-e7f8-901a-2b3c-4d5e6f7a8b9c") },
            new AchievementDefinition("Level10Achieved", "Level 10 Achieved", "Reach level 10", "You reached level 10!", "level", 0)
            { EntityId = 35, BusinessId = Guid.Parse("a4c5d6e7-f8a9-012b-3c4d-5e6f7a8b9c0d") },
            new AchievementDefinition("Level11Achieved", "Level 11 Achieved", "Reach level 11", "You reached level 11!", "level", 0)
            { EntityId = 36, BusinessId = Guid.Parse("b5d6e7f8-a9b0-123c-4d5e-6f7a8b9c0d1e") },
            new AchievementDefinition("Level12Achieved", "Level 12 Achieved", "Reach level 12", "You reached level 12!", "level", 0)
            { EntityId = 37, BusinessId = Guid.Parse("c6e7f8a9-b0c1-234d-5e6f-7a8b9c0d1e2f") },
            new AchievementDefinition("Level13Achieved", "Level 13 Achieved", "Reach level 13", "You reached level 13!", "level", 0)
            { EntityId = 38, BusinessId = Guid.Parse("d7f8a9b0-c1d2-345e-6f7a-8b9c0d1e2f3a") },
            new AchievementDefinition("Level14Achieved", "Level 14 Achieved", "Reach level 14", "You reached level 14!", "level", 0)
            { EntityId = 39, BusinessId = Guid.Parse("e8a9b0c1-d2e3-456f-7a8b-9c0d1e2f3a4b") },
            new AchievementDefinition("Level15Achieved", "Level 15 Achieved", "Reach level 15", "You reached level 15!", "level", 0)
            { EntityId = 40, BusinessId = Guid.Parse("f9b0c1d2-e3f4-567a-8b9c-0d1e2f3a4b5c") },

            // — League achievements —
            new AchievementDefinition("WoodLeague", "Wood League", "Be promoted to Wood league", "You’re now in Wood league!", "league", 50)
            { EntityId = 25, BusinessId = Guid.Parse("e2f3a4b5-c6d7-8e9f-0123-4b5c6d7e8f90") },
            new AchievementDefinition("StoneLeague", "Stone League", "Be promoted to Stone league", "You’re now in Stone league!", "league", 100)
            { EntityId = 26, BusinessId = Guid.Parse("f3a4b5c6-d7e8-9f01-2345-c6d7e8f901a2") },
            new AchievementDefinition("BronzeLeague", "Bronze League", "Be promoted to Bronze league", "You’re now in Bronze league!", "league", 150)
            { EntityId = 27, BusinessId = Guid.Parse("a4b5c6d7-e8f9-0123-4567-d7e8f901a2b3") },
            new AchievementDefinition("SilverLeague", "Silver League", "Be promoted to Silver league", "You’re now in Silver league!", "league", 200)
            { EntityId = 28, BusinessId = Guid.Parse("b5c6d7e8-f901-2345-6789-e8f901a2b3c4") },
            new AchievementDefinition("CrystalLeague", "Crystal League", "Be promoted to Crystal league", "You’re now in Crystal league!", "league", 250)
            { EntityId = 29, BusinessId = Guid.Parse("c6d7e8f9-0123-4567-89a0-f901a2b3c4d5") },
            new AchievementDefinition("EliteLeague", "Elite League", "Be promoted to Elite league", "You’re now in Elite league!", "league", 300)
            { EntityId = 30, BusinessId = Guid.Parse("d7e8f901-2345-6789-a0b1-0123c4d5e6f7") },
            new AchievementDefinition("ChampionLeague", "Champion League", "Be promoted to Champion league", "You’re now in Champion league!", "league", 350)
            { EntityId = 31, BusinessId = Guid.Parse("e8f901a2-3456-789a-0b1c-1234d5e6f7a8") },
            new AchievementDefinition("LegendLeague", "Legend League", "Be promoted to Legend league", "You’re now in Legend league!", "league", 400)
            { EntityId = 32, BusinessId = Guid.Parse("f901a2b3-4567-89a0-b1c2-2345e6f7a8b9") }
        );
    }
}