// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByGameIdQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByGameIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByGameIdQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;
    using ArbitrageFinder.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="GetGameByGameIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetGameDetailsQuery, Game}" />
    public class GetGameByGameIdQueryHandler : IRequestHandler<GetGameByGameIdQuery, Game>
    {
        /// <summary>
        /// The repository
        /// </summary>
        private readonly IGameRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameByGameIdQueryHandler"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public GetGameByGameIdQueryHandler(IGameRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="NotFoundException">The Game with uuid {request.GameId} was not found.</exception>
        public async Task<Game> Handle(GetGameByGameIdQuery request, CancellationToken cancellationToken)
        {
            Game game = await repository.GetAsync(request.GameId, cancellationToken);

            if (game is null)
            {
                throw new NotFoundException($"The Game with uuid {request.GameId} was not found.");
            }

            return game;
        }
    }
}