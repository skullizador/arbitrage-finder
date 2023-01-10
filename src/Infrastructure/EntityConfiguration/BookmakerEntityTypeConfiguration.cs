// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.EntityConfiguration
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="BookmakerEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Bookmaker}" />
    internal class BookmakerEntityTypeConfiguration : EntityTypeConfiguration<Bookmaker>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        protected override string TableName => "Bookmaker";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Bookmaker> builder)
        {
            builder.Property(f => f.Comments)
                .HasMaxLength(320);

            builder.Property(f => f.Description)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(f => f.BaseUrl)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(f => f.Teams);
        }
    }
}