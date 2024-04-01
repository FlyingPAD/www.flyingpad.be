using MB.Domain.Common;
using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MB.Persistence
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="options"></param>
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        // Main Tables
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
        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Board> Board { get; set; }

        // Extension Tables
        public DbSet<Document> ExtDocument { get; set; }
        public DbSet<Image> ExtImage { get; set; }
        public DbSet<Video> ExtVideo { get; set; }
        public DbSet<VideoYouTube> ExtVideoYouTube { get; set; }

        // Relation Tables
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


        /// <summary>
        /// Method : On Model Creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Find all Configurations in Assembly & Apply them to the builder

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);

            // - Artist / Style

            modelBuilder.Entity<RelationArtistStyle>()
                .HasKey(relation => new { relation.ArtistId, relation.StyleId });

            modelBuilder.Entity<RelationArtistStyle>()
                .HasOne(relation => relation.Artist)
                .WithMany(artist => artist.ArtistStyles)
                .HasForeignKey(relation => relation.ArtistId);

            modelBuilder.Entity<RelationArtistStyle>()
                .HasOne(relation => relation.Style)
                .WithMany(style => style.ArtistStyles)
                .HasForeignKey(relation => relation.StyleId);

            // - Franchise / Media

            modelBuilder.Entity<RelationFranchiseMedia>()
                .HasKey(relation => new { relation.FranchiseId, relation.MediaId });

            modelBuilder.Entity<RelationFranchiseMedia>()
                .HasOne(relation => relation.Franchise)
                .WithMany(franchise => franchise.FranchiseMedias)
                .HasForeignKey(relation => relation.FranchiseId);

            modelBuilder.Entity<RelationFranchiseMedia>()
                .HasOne(relation => relation.Media)
                .WithMany(media => media.FranchiseMedias)
                .HasForeignKey(relation => relation.MediaId);

            // - Franchise / Model

            modelBuilder.Entity<RelationFranchiseModel>()
                .HasKey(relation => new { relation.FranchiseId, relation.ModelId });

            modelBuilder.Entity<RelationFranchiseModel>()
                .HasOne(relation => relation.Franchise)
                .WithMany(franchise => franchise.FranchiseModels)
                .HasForeignKey(relation => relation.FranchiseId);

            modelBuilder.Entity<RelationFranchiseModel>()
                .HasOne(relation => relation.Model)
                .WithMany(model => model.FranchiseModels)
                .HasForeignKey(relation => relation.ModelId);

            // - Link / Artist

            modelBuilder.Entity<RelationLinkArtist>()
                .HasKey(relation => new { relation.LinkId, relation.ArtistId });

            modelBuilder.Entity<RelationLinkArtist>()
                .HasOne(relation => relation.Link)
                .WithMany(link => link.LinkArtists)
                .HasForeignKey(relation => relation.LinkId);

            modelBuilder.Entity<RelationLinkArtist>()
                .HasOne(relation => relation.Artist)
                .WithMany(artist => artist.LinkArtists)
                .HasForeignKey(relation => relation.ArtistId);

            // - Link / Category

            modelBuilder.Entity<RelationLinkCategory>()
                .HasKey(relation => new { relation.LinkId, relation.LinkCategoryId });

            modelBuilder.Entity<RelationLinkCategory>()
                .HasOne(relation => relation.Link)
                .WithMany(link => link.LinkCategories)
                .HasForeignKey(relation => relation.LinkId);

            modelBuilder.Entity<RelationLinkCategory>()
                .HasOne(relation => relation.LinkCategory)
                .WithMany(category => category.LinkCategories)
                .HasForeignKey(relation => relation.LinkCategoryId);

            // - Link / Model

            modelBuilder.Entity<RelationLinkModel>()
                .HasKey(relation => new { relation.LinkId, relation.ModelId });

            modelBuilder.Entity<RelationLinkModel>()
                .HasOne(relation => relation.Link)
                .WithMany(link => link.LinkModels)
                .HasForeignKey(relation => relation.LinkId);

            modelBuilder.Entity<RelationLinkModel>()
                .HasOne(relation => relation.Model)
                .WithMany(model => model.LinkModels)
                .HasForeignKey(relation => relation.ModelId);

            // - Mood / Artist

            modelBuilder.Entity<RelationMoodArtist>()
                .HasKey(relation => new { relation.MoodId, relation.ArtistId });

            modelBuilder.Entity<RelationMoodArtist>()
                .HasOne(relation => relation.Mood)
                .WithMany(mood => mood.MoodArtists)
                .HasForeignKey(relation => relation.MoodId);

            modelBuilder.Entity<RelationMoodArtist>()
                .HasOne(relation => relation.Artist)
                .WithMany(artist => artist.MoodArtists)
                .HasForeignKey(relation => relation.ArtistId);

            // - Mood / Model

            modelBuilder.Entity<RelationMoodModel>()
                .HasKey(relation => new { relation.MoodId, relation.ModelId });

            modelBuilder.Entity<RelationMoodModel>()
                .HasOne(relation => relation.Mood)
                .WithMany(mood => mood.MoodModels)
                .HasForeignKey(relation => relation.MoodId);

            modelBuilder.Entity<RelationMoodModel>()
                .HasOne(relation => relation.Model)
                .WithMany(model => model.MoodModels)
                .HasForeignKey(relation => relation.ModelId);

            // - Mood / Franchise

            modelBuilder.Entity<RelationMoodFranchise>()
                .HasKey(relation => new { relation.MoodId, relation.FranchiseId });

            modelBuilder.Entity<RelationMoodFranchise>()
                .HasOne(relation => relation.Mood)
                .WithMany(mood => mood.MoodFranchises)
                .HasForeignKey(relation => relation.MoodId);

            modelBuilder.Entity<RelationMoodFranchise>()
                .HasOne(relation => relation.Franchise)
                .WithMany(franchise => franchise.MoodFranchises)
                .HasForeignKey(relation => relation.FranchiseId);

            // - Mood / Tag

            modelBuilder.Entity<RelationMoodTag>()
                .HasKey(relation => new { relation.MoodId, relation.TagId });

            modelBuilder.Entity<RelationMoodTag>()
                .HasOne(relation => relation.Mood)
                .WithMany(mood => mood.MoodTags)
                .HasForeignKey(relation => relation.MoodId);

            modelBuilder.Entity<RelationMoodTag>()
                .HasOne(relation => relation.Tag)
                .WithMany(tag => tag.MoodTags)
                .HasForeignKey(relation => relation.TagId);


            // Post Deployment Script

            PostDeployment.AddData(modelBuilder);
        }

        /// <summary>
        /// Save Changes Async
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>()) // Handles the AutitableEntity Properties on Creation & Modification
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
}