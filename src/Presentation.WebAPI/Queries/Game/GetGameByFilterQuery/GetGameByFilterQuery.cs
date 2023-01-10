// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByFilterQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByFilterQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByFilterQuery
{
    using Domain.AggregateModels.Game;
    using MediatR;

    /// <summary>
    /// <see cref="GetGameByFilterQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Game}}" />
    public class GetGameByFilterQuery : IRequest<IEnumerable<Game>>
    {
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }
    }
}