// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="ITeamRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Team}" />
    public interface ITeamRepository : IRepository<Team>
    {
    }
}