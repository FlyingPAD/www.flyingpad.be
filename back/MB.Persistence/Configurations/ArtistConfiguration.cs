﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MB.Domain.ArtistAggregate;

namespace MB.Persistence.Configurations;

public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.HasKey(entity => entity.EntityId);
        builder.Property(entity => entity.EntityId)
            .ValueGeneratedOnAdd();
        builder.Property(entity => entity.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}