// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllBookmakersQuery.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetAllBookmakersQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetAllBookmakersQuery
{
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using MediatR;

    /// <summary>
    /// <see cref="GetAllBookmakersQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Bookmaker}}" />
    public class GetAllBookmakersQuery : IRequest<IEnumerable<Bookmaker>>
    {
    }
}