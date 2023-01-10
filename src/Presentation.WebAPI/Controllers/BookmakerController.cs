// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BookmakerController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// BookmakerController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Controllers
{
    using System.Net;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Bookmaker;
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Output.Bookmaker;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetAllBookmakersQuery;
    using ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetByBookmakerIdQuery;
    using ArbitrageFinder.Presentation.WebAPI.Utils;
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// <see cref="BookmakerController"/>
    /// </summary>
    /// <seealso cref="Controller" />
    [ApiController]
    [Route("api/v1")]
    public class BookmakerController : Controller
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
        /// Initializes a new instance of the <see cref="BookmakerController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public BookmakerController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets all asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Bookmaker")]
        [ProducesResponseType(typeof(IEnumerable<BookmakerDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            IEnumerable<Bookmaker> bookmakers = await this.mediator.Send(new GetAllBookmakersQuery(), cancellationToken);

            return this.Ok(this.mapper.Map<IEnumerable<BookmakerDto>>(bookmakers));
        }

        /// <summary>
        /// Gets the by bookmaker identifier asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Bookmaker/{BookmakerId}")]
        [ProducesResponseType(typeof(BookmakerDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetByBookmakerIdAsync([FromRoute] GetByBookmakerIdDto filter, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.mediator.Send(new GetByBookmakerIdQuery
            {
                BookmakerId = filter.BookmakerId,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<BookmakerDetailsDto>(bookmaker));
        }
    }
}