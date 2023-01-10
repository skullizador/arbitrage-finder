// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.OddBuilder
{
    using System;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;

    /// <summary>
    /// <see cref="IOddBuilder"/>
    /// </summary>
    /// <seealso cref="IOddBuilder"/>
    internal class OddBuilder : IOddBuilder
    {
        /// <summary>
        /// The odd
        /// </summary>
        private Odd odd;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Odd Build()
        {
            return this.odd;
        }

        /// <summary>
        /// Creates new odd.
        /// </summary>
        /// <param name="realOdd">The real odd.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="teamId">The team identifier.</param>
        /// <returns></returns>
        public IOddBuilder NewOdd(decimal realOdd, Guid bookmakerId, OddType type, Guid teamId)
        {
            this.odd = new(realOdd, bookmakerId, type, teamId);

            return this;
        }
    }
}