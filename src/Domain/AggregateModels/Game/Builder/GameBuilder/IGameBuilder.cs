// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGameBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IGameBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.GameBuilder
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Game;

    /// <summary>
    /// <see cref="IGameBuilder"/>
    /// </summary>
    public interface IGameBuilder
    {
        /// <summary>
        /// Adds the odds.
        /// </summary>
        /// <param name="odds">The odds.</param>
        /// <returns></returns>
        IGameBuilder AddOdds(IEnumerable<Odd> odds);

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Game Build();

        /// <summary>
        /// Creates new game.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="teamAId">The team a identifier.</param>
        /// <param name="teamBId">The team b identifier.</param>
        /// <returns></returns>
        IGameBuilder NewGame(DateTime date, Guid teamAId, Guid teamBId);
    }
}