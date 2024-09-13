using MB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RBookModelConfiguration : IEntityTypeConfiguration<RelationBookModel>
{
    public void Configure(EntityTypeBuilder<RelationBookModel> builder)
    {
        builder.HasKey(relation => new { relation.BookId, relation.ModelId });

        builder.HasOne(relation => relation.Book)
            .WithMany(mood => mood.BookModel)
            .HasForeignKey(relation => relation.BookId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Model)
            .WithMany(tag => tag.BookModel)
            .HasForeignKey(relation => relation.ModelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}