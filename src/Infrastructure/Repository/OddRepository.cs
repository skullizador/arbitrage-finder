// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Repository
{
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;

    /// <summary>
    /// <see cref="OddRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Odd}" />
    /// <seealso cref="IOddRepository" />
    internal class OddRepository : GenericRepository<Odd>, IOddRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OddRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public OddRepository(
                ArbitrageFinderDBContext context)
                : base(context)
        {
        }
    }
}