// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamDetailsDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    /// <see cref="TeamDetailsDto"/>
    /// </summary>
    public class TeamDetailsDto
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the UUID.
        /// </summary>
        /// <value>
        /// The UUID.
        /// </value>
        public Guid UUID { get; set; }
    }
}