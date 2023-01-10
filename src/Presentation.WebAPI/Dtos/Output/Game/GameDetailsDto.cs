// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Game
{
    /// <summary>
    /// <see cref="GameDetailsDto"/>
    /// </summary>
    public class GameDetailsDto
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the odds.
        /// </summary>
        /// <value>
        /// The odds.
        /// </value>
        public List<OddDetailsDto> Odds { get; set; }

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
        /// Gets or sets the UUID.
        /// </summary>
        /// <value>
        /// The UUID.
        /// </value>
        public Guid UUID { get; set; }
    }
}