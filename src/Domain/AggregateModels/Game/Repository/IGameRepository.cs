// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGameRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IGameRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="IGameRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Game}" />
    public interface IGameRepository : IRepository<Game>
    {
        /// <summary>
        /// Gets the by filters asynchronous.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<Game>> GetByFiltersAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
    }
}