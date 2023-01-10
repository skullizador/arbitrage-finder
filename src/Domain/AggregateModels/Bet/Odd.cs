// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Odd.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// Odd
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bet
{
    using System;
    using System.Collections.Generic;
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="Odd"/>
    /// </summary>
    /// <seealso cref="ValueObject" />
    public class Odd : ValueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Odd"/> class.
        /// </summary>
        /// <param name="oddId">The odd identifier.</param>
        /// <param name="bookmakerId">The bookmaker identifier.</param>
        public Odd(Guid oddId, Guid bookmakerId)
        {
            this.OddId = oddId;
            this.BookmakerId = bookmakerId;
        }

        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>
        /// The bookmaker identifier.
        /// </value>
        public Guid BookmakerId { get; set; }

        /// <summary>
        /// Gets or sets the odd identifier.
        /// </summary>
        /// <value>
        /// The odd identifier.
        /// </value>
        public Guid OddId { get; set; }

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.OddId;
            yield return this.BookmakerId;
        }
    }
}