// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CombinationService.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CombinationService
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Domain.Services.Bet.CombinationService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Builder.CombinationBuilder;
    using ArbitrageFinder.Domain.AggregateModels.Game.Enum;
    using ArbitrageFinder.Domain.Services.Bet.ArbitrageCalculatorService;
    using ArbitrageFinder.Domain.Services.Bet.ProfitCalculatorService;
    using BetOdd = AggregateModels.Bet.Odd;
    using GameOdd = AggregateModels.Game.Odd;

    /// <summary>
    /// <see cref="CombinationService"/>
    /// </summary>
    /// <seealso cref="ICombinationService" />
    internal class CombinationService : ICombinationService
    {
        /// <summary>
        /// The arbitrage calculator service
        /// </summary>
        private readonly IArbitrageCalculatorService arbitrageCalculatorService;

        /// <summary>
        /// The combination builder
        /// </summary>
        private readonly ICombinationBuilder combinationBuilder;

        /// <summary>
        /// The profit calculator service
        /// </summary>
        private readonly IProfitCalculatorService profitCalculatorService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CombinationService"/> class.
        /// </summary>
        /// <param name="arbitrageCalculatorService">The arbitrage calculator service.</param>
        /// <param name="combinationBuilder">The combination builder.</param>
        /// <param name="profitCalculatorService">The profit calculator service.</param>
        public CombinationService(
            IArbitrageCalculatorService arbitrageCalculatorService,
            ICombinationBuilder combinationBuilder,
            IProfitCalculatorService profitCalculatorService)
        {
            this.arbitrageCalculatorService = arbitrageCalculatorService;
            this.profitCalculatorService = profitCalculatorService;
            this.combinationBuilder = combinationBuilder;
        }

        /// <summary>
        /// Calculates the combinations asynchronous.
        /// </summary>
        /// <param name="game">The game.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Combination>> CalculateCombinationsAsync(Game game, CancellationToken cancellationToken)
        {
            List<GameOdd> teamAOdds = game.Odds
                .Where(odd => odd.TeamId == game.TeamAId)
                .ToList();

            List<GameOdd> teamBOdds = game.Odds
                .Where(odd => odd.TeamId == game.TeamBId)
                .ToList();

            List<GameOdd> drawOdds = game.Odds
                .Where(odd => odd.Type is OddType.X)
                .ToList();

            if (drawOdds.Any())
            {
                return await this.Calculate3WayBetCombinationsAsync(teamAOdds, teamBOdds, drawOdds, cancellationToken);
            }

            return await this.Calculate2WayBetCombinationsAsync(teamAOdds, teamBOdds, cancellationToken);
        }

        /// <summary>
        /// Calculate2s the way bet combinations asynchronous.
        /// </summary>
        /// <param name="teamAOdds">The team a odds.</param>
        /// <param name="teamBOdds">The team b odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        private async Task<IEnumerable<Combination>> Calculate2WayBetCombinationsAsync(List<GameOdd> teamAOdds, List<GameOdd> teamBOdds, CancellationToken cancellationToken)
        {
            List<Combination> combinations = new();

            foreach (GameOdd teamAOdd in teamAOdds)
            {
                foreach (GameOdd teamBOdd in teamBOdds)
                {
                    decimal arbitragePercentage = await this.arbitrageCalculatorService.Calculate2WayBetArbitragePercentageAsync(teamAOdd, teamBOdd, cancellationToken);

                    decimal profitMargin = await this.profitCalculatorService.CalculateProfitMarginAsync(arbitragePercentage, cancellationToken);

                    if (profitMargin > 0)
                    {
                        this.CreateCombination(combinations, teamAOdd, teamBOdd, null, profitMargin);
                    }
                }
            }

            return combinations;
        }

        /// <summary>
        /// Calculate3s the way bet combinations asynchronous.
        /// </summary>
        /// <param name="teamAOdds">The team a odds.</param>
        /// <param name="teamBOdds">The team b odds.</param>
        /// <param name="drawOdds">The draw odds.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        private async Task<IEnumerable<Combination>> Calculate3WayBetCombinationsAsync(List<GameOdd> teamAOdds, List<GameOdd> teamBOdds, List<GameOdd> drawOdds, CancellationToken cancellationToken)
        {
            List<Combination> combinations = new();

            foreach (GameOdd teamAOdd in teamAOdds)
            {
                foreach (GameOdd teamBOdd in teamBOdds)
                {
                    foreach (GameOdd drawOdd in drawOdds)
                    {
                        decimal arbitragePercentage = await this.arbitrageCalculatorService.Calculate3WayBetArbitragePercentageAsync(teamAOdd, teamBOdd, drawOdd, cancellationToken);

                        decimal profitMargin = await this.profitCalculatorService.CalculateProfitMarginAsync(arbitragePercentage, cancellationToken);

                        if (profitMargin > 0)
                        {
                            this.CreateCombination(combinations, teamAOdd, teamBOdd, drawOdd, profitMargin);
                        }
                    }
                }
            }

            return combinations;
        }

        /// <summary>
        /// Creates the combination.
        /// </summary>
        /// <param name="combinations">The combinations.</param>
        /// <param name="teamAOdd">The team a odd.</param>
        /// <param name="teamBOdd">The team b odd.</param>
        /// <param name="drawOdd">The draw odd.</param>
        /// <param name="profitMargin">The profit margin.</param>
        private void CreateCombination(List<Combination> combinations, GameOdd teamAOdd, GameOdd teamBOdd, GameOdd drawOdd, decimal profitMargin)
        {
            BetOdd teamABetOdd = new(teamAOdd.UUId, teamAOdd.BookmakerId);
            BetOdd teamBBetOdd = new(teamBOdd.UUId, teamBOdd.BookmakerId);
            BetOdd drawBetOdd = (drawOdd is null) ? null : new(drawOdd.UUId, drawOdd.BookmakerId);

            Combination combination = this.combinationBuilder
                .NewCombination(teamABetOdd, drawBetOdd, teamBBetOdd, profitMargin)
                .Build();

            combinations.Add(combination);
        }
    }
}