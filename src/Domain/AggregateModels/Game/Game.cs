// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Game.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Game
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Game"/>
    /// </summary>
    /// <seealso cref="EntityBase" />
    /// <seealso cref="IAggregateRoot" />
    public class Game : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The odds
        /// </summary>
        private readonly List<Odd> odds;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game" /> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="teamAId">The team a identifier.</param>
        /// <param name="teamBId">The team b identifier.</param>
        internal Game(DateTime date, Guid teamAId, Guid teamBId)
            : this()
        {
            this.Date = date;
            this.TeamAId = teamAId;
            this.TeamBId = teamBId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// </summary>
        protected Game()
        {
            this.odds = new List<Odd>();
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Gets the odds.
        /// </summary>
        /// <value>
        /// The odds.
        /// </value>
        public virtual IReadOnlyCollection<Odd> Odds => this.odds;

        /// <summary>
        /// Gets the team a identifier.
        /// </summary>
        /// <value>
        /// The team a identifier.
        /// </value>
        public Guid TeamAId { get; private set; }

        /// <summary>
        /// Gets the team b identifier.
        /// </summary>
        /// <value>
        /// The team b identifier.
        /// </value>
        public Guid TeamBId { get; private set; }

        /// <summary>
        /// Adds the odd.
        /// </summary>
        /// <param name="odd">The odd.</param>
        /// <exception cref="ArgumentNullException">odd - The Odd is null.</exception>
        public void AddOdd(Odd odd)
        {
            if (odd is null)
            {
                throw new ArgumentNullException(nameof(odd), "The Odd is null.");
            }

            this.odds.Add(odd);
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