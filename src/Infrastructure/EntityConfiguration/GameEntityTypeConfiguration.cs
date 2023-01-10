// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.EntityConfiguration
{
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="GameEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Game}" />
    internal class GameEntityTypeConfiguration : EntityTypeConfiguration<Game>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        protected override string TableName => "Game";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Game> builder)
        {
            builder.Property(f => f.Date)
                .IsRequired();

            builder.Property(f => f.TeamAId)
                .IsRequired();

            builder.Property(f => f.TeamBId)
                .IsRequired();

            builder.HasMany(f => f.Odds);
        }
    }
}