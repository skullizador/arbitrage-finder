// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOddBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IOddBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.OddBuilder
{
    using System;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;

    /// <summary>
    /// <see cref="IOddBuilder"/>
    /// </summary>
    public interface IOddBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Odd Build();

        /// <summary>
        /// Creates new odd.
        /// </summary>
        /// <param name="realOdd">The real odd.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="teamId">The team identifier.</param>
        /// <returns></returns>
        IOddBuilder NewOdd(decimal realOdd, Guid bookmakerId, OddType type, Guid teamId);
    }
}