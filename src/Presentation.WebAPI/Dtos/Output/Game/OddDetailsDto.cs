// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OddDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// OddDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Game
{
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;

    /// <summary>
    /// <see cref="OddDetailsDto"/>
    /// </summary>
    public class OddDetailsDto
    {
        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>
        /// The bookmaker identifier.
        /// </value>
        public Guid BookmakerId { get; set; }

        /// <summary>
        /// Gets or sets the real odd.
        /// </summary>
        /// <value>
        /// The real odd.
        /// </value>
        public decimal RealOdd { get; set; }

        /// <summary>
        /// Gets or sets the team identifier.
        /// </summary>
        /// <value>
        /// The team identifier.
        /// </value>
        public Guid TeamId { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public OddType Type { get; set; }

        /// <summary>
        /// Gets or sets the UUID.
        /// </summary>
        /// <value>
        /// The UUID.
        /// </value>
        public Guid UUID { get; set; }
    }
}