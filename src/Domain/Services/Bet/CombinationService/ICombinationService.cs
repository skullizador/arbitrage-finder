// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICombinationService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ICombinationService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.CombinationService
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Game;

    /// <summary>
    /// <see cref="ICombinationService"/>
    /// </summary>
    public interface ICombinationService
    {
        /// <summary>
        /// Calculates the combinations asynchronous.
        /// </summary>
        /// <param name="game">The game.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<Combination>> CalculateCombinationsAsync(Game game, CancellationToken cancellationToken);
    }
}