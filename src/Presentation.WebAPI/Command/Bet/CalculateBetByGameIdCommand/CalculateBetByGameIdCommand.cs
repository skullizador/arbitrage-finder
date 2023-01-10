// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetByGameIdCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetByGameIdCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Command.Bet.CalculateBetByGameIdCommand
{
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using MediatR;

    /// <summary>
    /// <see cref="CalculateBetByGameIdCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Bet}" />
    public class CalculateBetByGameIdCommand : IRequest<Bet>
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