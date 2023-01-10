// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetBetByGameDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetBetByGameDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bet
{
    /// <summary>
    /// <see cref="GetBetByGameDto"/>
    /// </summary>
    public class GetBetByGameDto
    {
        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>
        /// The game identifier.
        /// </value>
        public Guid GameId { get; set; }
    }
}