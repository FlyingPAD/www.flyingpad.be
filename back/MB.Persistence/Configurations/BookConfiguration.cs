using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.Entities;

namespace MB.Persistence.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(entity => entity.EntityId);

        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();
    }
}
