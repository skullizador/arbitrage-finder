// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Game
{
    /// <summary>
    /// <see cref="GameDto"/>
    /// </summary>
    public class GameDto
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the team a identifier.
        /// </summary>
        /// <value>
        /// The team a identifier.
        /// </value>
        public Guid TeamAId { get; set; }

        /// <summary>
        /// Gets or sets the team b identifier.
        /// </summary>
        /// <value>
        /// The team b identifier.
        /// </value>
        public Guid TeamBId { get; set; }

        /// <summary>
        /// Gets or sets the uu identifier.
        /// </summary>
        /// <value>
        /// The uu identifier.
        /// </value>
        public Guid UUId { get; set; }
    }
}