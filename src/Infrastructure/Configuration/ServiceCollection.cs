﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamBuilder.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Infrastructure.Configuration
{
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;
    using ArbitrageFinder.Infrastructure.Repository;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the infrastructure services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IBookmakerRepository, BookmakerRepository>();

            services.AddScoped<ICombinationRepository, CombinationRepository>();

            services.AddScoped<IOddRepository, OddRepository>();

            services.AddScoped<IGameRepository, GameRepository>();

            services.AddScoped<ITeamRepository, TeamRepository>();

            services.AddScoped<IBetRepository, BetRepository>();
        }
    }
}