// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bookmaker.Builder.BookmakerBuilder
{
    /// <summary>
    /// <see cref="BookmakerBuilder"/>
    /// </summary>
    /// <seealso cref="IBookmakerBuilder" />
    internal class BookmakerBuilder : IBookmakerBuilder
    {
        /// <summary>
        /// The bookmaker
        /// </summary>
        private Bookmaker bookmaker;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Bookmaker Build()
        {
            return this.bookmaker;
        }

        /// <summary>
        /// Creates new bookmaker.
        /// </summary>
        /// <param name="comments">The comments.</param>
        /// <param name="description">The description.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public IBookmakerBuilder NewBookmaker(string comments, string description, string baseUrl, string name)
        {
            this.bookmaker = new(comments, description, baseUrl, name);

            return this;
        }
    }
}