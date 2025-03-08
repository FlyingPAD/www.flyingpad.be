using MB.Domain.ModelAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Persistence.Configurations.Relations;

public class RFranchiseModelConfiguration : IEntityTypeConfiguration<RelationFranchiseModel>
{
    public void Configure(EntityTypeBuilder<RelationFranchiseModel> builder)
    {
        builder.HasKey(relation => new { relation.FranchiseId, relation.ModelId });

        builder.HasOne(relation => relation.Franchise)
            .WithMany(franchise => franchise.FranchiseModels)
            .HasForeignKey(relation => relation.FranchiseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(relation => relation.Model)
            .WithMany(model => model.FranchiseModels)
            .HasForeignKey(relation => relation.ModelId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}