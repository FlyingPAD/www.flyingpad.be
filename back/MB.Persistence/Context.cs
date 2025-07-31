using MB.Domain;
using MB.Domain.ArtistAggregate;
using MB.Domain.BoardAggregate;
using MB.Domain.BookAggregate;
using MB.Domain.FranchiseAggregate;
using MB.Domain.LinkAggregate;
using MB.Domain.LinkCategoryAggregate;
using MB.Domain.MediumAggregate;
using MB.Domain.ModelAggregate;
using MB.Domain.MoodAggregate;
using MB.Domain.StyleAggregate;
using MB.Domain.TagAggregate;
using MB.Domain.TagCategoryAggregate;
using MB.Domain.TaskCategoryAggregate;
using MB.Domain.UserAggregate;
using MB.Domain.SeasonAggregate;
using MB.Domain.LeagueAggregate;
using MB.Domain.LevelAggregate;
using MB.Domain.AchievementAggregate;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence;

/// <summary>
/// DÉPRÉCIÉ ( en cours de migration ) : utilisez désormais <see cref="WriteContext"/> pour les écritures
/// et <see cref="ReadContext"/> pour les lectures.
/// </summary>
public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Mood> Moods { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<TagCategory> TagCategories { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Style> Styles { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Franchise> Franchises { get; set; }
    public DbSet<Media> Medias { get; set; }
    public DbSet<Link> Links { get; set; }
    public DbSet<LinkCategory> LinkCategories { get; set; }
    public DbSet<Domain.TaskAggregate.Task> Tasks { get; set; }
    public DbSet<TaskCategory> TaskCategories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<EmailVerificationToken> EmailVerificationTokens { get; set; }
    public DbSet<Board> Boards { get; set; }
    public DbSet<Book> Books { get; set; }

    // Relations.
    public DbSet<RelationArtistStyle> RArtistStyle { get; set; }
    public DbSet<RelationFranchiseMedia> RFranchiseMedia { get; set; }
    public DbSet<RelationFranchiseModel> RFranchiseModel { get; set; }
    public DbSet<RelationLinkArtist> RLinkArtist { get; set; }
    public DbSet<RelationLinkCategory> RLinkCategory { get; set; }
    public DbSet<RelationLinkModel> RLinkModel { get; set; }
    public DbSet<RelationMoodArtist> RMoodArtist { get; set; }
    public DbSet<RelationMoodFranchise> RMoodFranchise { get; set; }
    public DbSet<RelationMoodModel> RMoodModel { get; set; }
    public DbSet<RelationMoodTag> RMoodTag { get; set; }
    public DbSet<RelationBookFranchise> RBookFranchise { get; set; }
    public DbSet<RelationBookModel> RBookModel { get; set; }

    // Gamification
    public DbSet<Season> Seasons { get; set; }
    public DbSet<LeagueDefinition> LeagueDefinitions { get; set; }
    public DbSet<LevelDefinition> LevelDefinitions { get; set; }
    public DbSet<AchievementDefinition> AchievementDefinitions { get; set; }
    public DbSet<UserAchievement> UserAchievements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.Created = DateTime.UtcNow;
                    break;
                case EntityState.Modified:
                    entry.Entity.Modified = DateTime.UtcNow;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}