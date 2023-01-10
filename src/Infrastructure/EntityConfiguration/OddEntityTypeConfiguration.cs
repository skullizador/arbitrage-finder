﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddEntityTypeConfiguration.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddEntityTypeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.EntityConfiguration
{
    using System;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="OddEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Odd}" />
    internal class OddEntityTypeConfiguration : EntityTypeConfiguration<Odd>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        protected override string TableName => "Odd";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Odd> builder)
        {
            builder.Property(f => f.BookmakerId)
                .IsRequired();

            builder.Property(f => f.RealOdd)
                .IsRequired();

            builder.Property(f => f.Type)
                .HasConversion(
                    v => v.ToString(),
                    v => (OddType)Enum.Parse(typeof(OddType), v))
                .HasMaxLength(20);
        }
    }
}