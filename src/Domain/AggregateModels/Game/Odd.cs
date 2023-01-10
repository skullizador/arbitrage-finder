// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Odd.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Odd
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Odd"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class Odd : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Odd" /> class.
        /// </summary>
        /// <param name="realOdd">The real odd.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        /// <param name="type">The type.</param>
        /// <param name="teamId">The team identifier.</param>
        internal Odd(decimal realOdd, Guid bookmakerId, OddType type, Guid? teamId)
            : this()
        {
            this.Type = type;
            this.RealOdd = realOdd;
            this.BookmakerId = bookmakerId;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Odd"/> class.
        /// </summary>
        protected Odd()
        {
        }

        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>
        /// The bookmaker identifier.
        /// </value>
        public Guid BookmakerId { get; private set; }

        /// <summary>
        /// Gets or sets the real odd.
        /// </summary>
        /// <value>The real odd.</value>
        public decimal RealOdd { get; private set; }

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        /// <value>
        /// The team.
        /// </value>
        public Guid? TeamId { get; private set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public OddType Type { get; private set; }

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