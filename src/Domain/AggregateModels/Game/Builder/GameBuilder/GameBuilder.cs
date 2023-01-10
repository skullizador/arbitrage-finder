// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.GameBuilder
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="GameBuilder"/>
    /// </summary>
    /// <seealso cref="IGameBuilder" />
    internal class GameBuilder : IGameBuilder
    {
        /// <summary>
        /// The game
        /// </summary>
        private Game game;

        /// <summary>
        /// Adds the odds.
        /// </summary>
        /// <param name="odds">The odds.</param>
        /// <returns></returns>
        public IGameBuilder AddOdds(IEnumerable<Odd> odds)
        {
            foreach (Odd item in odds)
            {
                this.game.AddOdd(item);
            }

            return this;
        }

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Game Build()
        {
            return this.game;
        }

        /// <summary>
        /// Creates new game.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="teamAId">The team a identifier.</param>
        /// <param name="teamBId">The team b identifier.</param>
        /// <returns></returns>
        public IGameBuilder NewGame(DateTime date, Guid teamAId, Guid teamBId)
        {
            this.game = new(date, teamAId, teamBId);

            return this;
        }
    }
}