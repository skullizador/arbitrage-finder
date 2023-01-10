// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerDto.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bookmaker
{
    /// <summary>
    ///   <see cref="BookmakerDto" />
    /// </summary>
    public class BookmakerDto
    {
        /// <summary>
        /// Gets or sets the base URL.
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the uu identifier.
        /// </summary>
        /// <value>
        /// The uu identifier.
        /// </value>
        public Guid UUId { get; set; }
    }
}