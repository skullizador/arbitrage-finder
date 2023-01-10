// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByGameIdDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByGameIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Game
{
    /// <summary>
    /// <see cref="GetGameByGameIdDto"/>
    /// </summary>
    public class GetGameByGameIdDto
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