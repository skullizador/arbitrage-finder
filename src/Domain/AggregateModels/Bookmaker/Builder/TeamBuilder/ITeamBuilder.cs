// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.TeamBuilder
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;

    /// <summary>
    /// <see cref="ITeamBuilder"/>
    /// </summary>
    public interface ITeamBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Team Build();

        /// <summary>
        /// Creates new team.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        ITeamBuilder NewTeam(string name);
    }
}