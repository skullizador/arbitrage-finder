// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByBookmakerIdQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByBookmakerIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetByBookmakerIdQuery
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="GetByBookmakerIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Bookmaker}" />
    public class GetByBookmakerIdQuery : IRequest<Bookmaker>
    {
        /// <summary>
        /// Gets or sets the bookmaker identifier.
        /// </summary>
        /// <value>
        /// The bookmaker identifier.
        /// </value>
        public Guid BookmakerId { get; set; }
    }
}