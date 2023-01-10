// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bookmaker.Builder.BookmakerBuilder
{
    /// <summary>
    /// <see cref="IBookmakerBuilder"/>
    /// </summary>
    public interface IBookmakerBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Bookmaker Build();

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        IBookmakerBuilder NewBookmaker(string comments, string description, string baseUrl, string name);
    }
}