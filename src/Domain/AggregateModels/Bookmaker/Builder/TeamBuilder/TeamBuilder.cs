// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Builder.TeamBuilder
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;

    /// <summary>
    /// <see cref="TeamBuilder"/>
    /// </summary>
    /// <seealso cref="ITeamBuilder" />
    internal class TeamBuilder : ITeamBuilder
    {
        /// <summary>
        /// The team
        /// </summary>
        private Team team;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Team Build()
        {
            return this.team;
        }

        /// <summary>
        /// Creates new team.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public ITeamBuilder NewTeam(string name)
        {
            this.team = new(name);

            return this;
        }
    }
}