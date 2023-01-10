// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GameController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Controller
{
    using System.Net;
    using ArbitrageFinder.Domain.AggregateModels.Game;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Game;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Game;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByFilterQuery;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Game.GetGameByGameIdQuery;
    using ArbitrageFinder.Presentation.WebAPI.Utils;
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="GameController"/>
    /// </summary>
    /// <seealso cref="Controller" />
    [ApiController]
    [Route("api/v1")]
    public class GameController : Controller
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public GameController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets the by filter asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Game")]
        [ProducesResponseType(typeof(IEnumerable<GameDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByFilterAsync([FromQuery] GetGameByFilterDto filter, CancellationToken cancellationToken)
        {
            IEnumerable<Game> games = await this.mediator.Send(new GetGameByFilterQuery
            {
                StartDate = filter.StartDate,
                EndDate = filter.EndDate,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<IEnumerable<GameDto>>(games));
        }

        /// <summary>
        /// Gets the by game identifier asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Game/{GameId}")]
        [ProducesResponseType(typeof(GameDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetByGameIdAsync([FromRoute] GetGameByGameIdDto filter, CancellationToken cancellationToken)
        {
            Game game = await this.mediator.Send(new GetGameByGameIdQuery
            {
                GameId = filter.GameId,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<GameDetailsDto>(game));
        }
    }
}