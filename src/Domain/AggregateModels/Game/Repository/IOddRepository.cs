// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IOddRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// IOddRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.AggregateModels.Game.Repository
{
    using ArbitrageFinder.Domain.SeedWork;

    /// <summary>
    /// <see cref="IOddRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Odd}" />
    public interface IOddRepository : IRepository<Odd>
    {
    }
}