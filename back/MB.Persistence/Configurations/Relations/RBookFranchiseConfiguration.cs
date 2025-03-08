using MB.Domain.FranchiseAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RBookFranchiseConfiguration : IEntityTypeConfiguration<RelationBookFranchise>
{
    public void Configure(EntityTypeBuilder<RelationBookFranchise> builder)
    {
        builder.HasKey(relation => new { relation.BookId, relation.FranchiseId });

        builder.HasOne(relation => relation.Book)
            .WithMany(mood => mood.BookFranchise)
            .HasForeignKey(relation => relation.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Franchise)
            .WithMany(tag => tag.BookFranchise)
            .HasForeignKey(relation => relation.FranchiseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}