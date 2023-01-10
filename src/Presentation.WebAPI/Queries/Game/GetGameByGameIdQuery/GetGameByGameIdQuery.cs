// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByGameIdQuery.cs" company="Openvia">
//     Copyright (c) Openvia. All rights reserved.
// </copyright>
// <summary>
// GetGameByGameIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByGameIdQuery
{
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using MediatR;

    /// <summary>
    /// <see cref="GetGameByGameIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Game}" />
    public class GetGameByGameIdQuery : IRequest<Game>
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