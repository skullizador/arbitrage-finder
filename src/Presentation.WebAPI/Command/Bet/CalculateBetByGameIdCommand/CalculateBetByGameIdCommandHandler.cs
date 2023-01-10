// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculateBetByGameIdCommandHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// CalculateBetByGameIdCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Command.Bet.CalculateBetByGameIdCommand
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bet;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Builder.BetBuilder;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Enum;
    using ArbitrageFinder.Domain.AggregateModels.Bet.Repository;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;
    using ArbitrageFinder.Domain.Exceptions;
    using ArbitrageFinder.Domain.Services.Bet.BetService;
    using ArbitrageFinder.Domain.Services.Bet.CombinationService;
    using MediatR;

    /// <summary>
    /// <see cref="CalculateBetByGameIdCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{CalculateBetByGameIdCommand, Bet}" />
    public class CalculateBetByGameIdCommandHandler : IRequestHandler<CalculateBetByGameIdCommand, Bet>
    {
        /// <summary>
        /// The bet builder
        /// </summary>
        private readonly IBetBuilder betBuilder;

        /// <summary>
        /// The bet repository
        /// </summary>
        private readonly IBetRepository betRepository;

        /// <summary>
        /// The bet service
        /// </summary>
        private readonly IBetService betService;

        /// <summary>
        /// The combination service
        /// </summary>
        private readonly ICombinationService combinationService;

        /// <summary>
        /// The game repository
        /// </summary>
        private readonly IGameRepository gameRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateBetByGameIdCommandHandler"/> class.
        /// </summary>
        /// <param name="betBuilder">The bet builder.</param>
        /// <param name="betRepository">The bet repository.</param>
        /// <param name="betService">The bet service.</param>
        /// <param name="combinationService">The combination service.</param>
        /// <param name="gameRepository">The game repository.</param>
        public CalculateBetByGameIdCommandHandler(
            IBetBuilder betBuilder,
            IBetRepository betRepository,
            IBetService betService,
            ICombinationService combinationService,
            IGameRepository gameRepository)
        {
            this.betBuilder = betBuilder;
            this.betService = betService;
            this.betRepository = betRepository;
            this.combinationService = combinationService;
            this.gameRepository = gameRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="NotFoundException">The bet with id {request.GameId} wasn't found.</exception>
        public async Task<Bet> Handle(CalculateBetByGameIdCommand request, CancellationToken cancellationToken)
        {
            Game game = await this.gameRepository.GetAsync(request.GameId, cancellationToken);

            if (game is null)
            {
                throw new NotFoundException($"The bet with id {request.GameId} wasn't found.");
            }

            BetType betType = await this.betService.GetBetTypeAsync(game, cancellationToken);

            IEnumerable<Combination> combinations = await this.combinationService.CalculateCombinationsAsync(game, cancellationToken);

            Bet bet = this.betBuilder
                .NewBet(game.UUId, betType)
                .AddCombinations(combinations.ToList())
                .Build();

            await this.betRepository.AddAsync(bet, cancellationToken);

            await this.betRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return bet;
        }
    }
}