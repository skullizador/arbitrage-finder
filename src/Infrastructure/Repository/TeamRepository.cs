// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Repository
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository;

    /// <summary>
    /// <see cref="TeamRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Team}" />
    /// <seealso cref="ITeamRepository" />
    internal class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public TeamRepository(
                ArbitrageFinderDBContext context)
                : base(context)
        {
        }
    }
}