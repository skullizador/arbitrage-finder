// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BetService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BetService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.BetService
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;

    /// <summary>
    /// <see cref="IBetService"/>
    /// </summary>
    /// <seealso cref="IBetService" />
    internal class BetService : IBetService
    {
        /// <summary>
        /// Gets the bet type asynchronous.
        /// </summary>
        /// <param name="game">The game.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public Task<BetType> GetBetTypeAsync(Game game, CancellationToken cancellationToken)
        {
            if (game.Odds.Any(odd => odd.Type is OddType.X))
            {
                return Task.FromResult(BetType.ThreeWayBet);
            }

            return Task.FromResult(BetType.TwoWayBet);
        }
    }
}