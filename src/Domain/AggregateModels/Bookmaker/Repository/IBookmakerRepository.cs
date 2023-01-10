// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBookmakerRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IBookmakerRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository
{
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="IBookmakerRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Bookmaker}" />
    public interface IBookmakerRepository : IRepository<Bookmaker>
    {
    }
}