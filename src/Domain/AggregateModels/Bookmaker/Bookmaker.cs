// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bookmaker.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Bookmaker
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bookmaker
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Bookmaker"/>
    /// </summary>
    /// <seealso cref="EntityBase" />
    /// <seealso cref="IAggregateRoot" />
    public class Bookmaker : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The teams
        /// </summary>
        private readonly List<Team> teams;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmaker" /> class.
        /// </summary>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="name">The name.</param>
        internal Bookmaker(string comments, string description, string baseUrl, string name)
            : this()
        {
            this.Comments = comments;
            this.Description = description;
            this.BaseUrl = baseUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmaker"/> class.
        /// </summary>
        protected Bookmaker()
        {
            this.teams = new();
        }

        /// <summary>
        /// Gets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; private set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public string Comments { get; private set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the teams.
        /// </summary>
        /// <value>
        /// The teams.
        /// </value>
        public virtual IReadOnlyCollection<Team> Teams => this.teams;

        /// <summary>
        /// Adds the team.
        /// </summary>
        /// <param name="team">The team.</param>
        /// <exception cref="ArgumentNullException">The Team is null.</exception>
        public void AddTeam(Team team)
        {
            if (team is null)
            {
                throw new ArgumentNullException("The Team is null.");
            }

            this.teams.Add(team);
        }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}