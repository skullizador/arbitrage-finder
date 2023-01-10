// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// <see cref="GameRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Game}" />
    /// <seealso cref="IGameRepository" />
    internal class GameRepository : GenericRepository<Game>, IGameRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public GameRepository(
                ArbitrageFinderDBContext context)
                : base(context)
        {
        }

        /// <summary>
        /// Gets the by filters asynchronous.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Game>> GetByFiltersAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            return await this.Entities.Where(game =>
                game.Date >= startDate &&
                game.Date <= endDate)
                .ToListAsync(cancellationToken);
        }
    }
}