// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByFilterQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByFilterQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByFilterQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Game.Repository;
    using Domain.AggregateModels.Game;
    using MediatR;

    /// <summary>
    /// <see cref="GetGameByFilterQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetGameByFilterQuery, IEnumerable{Game}}" />
    public class GetGameByFilterQueryHandler : IRequestHandler<GetGameByFilterQuery, IEnumerable<Game>>
    {
        /// <summary>
        /// The game repository
        /// </summary>
        private readonly IGameRepository gameRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameByFilterQueryHandler"/> class.
        /// </summary>
        /// <param name="gameRepository">The game repository.</param>
        public GetGameByFilterQueryHandler(IGameRepository gameRepository)
        {
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
        public async Task<IEnumerable<Game>> Handle(GetGameByFilterQuery request, CancellationToken cancellationToken)
        {
            return await this.gameRepository.GetByFiltersAsync(request.StartDate, request.EndDate, cancellationToken);
        }
    }
}