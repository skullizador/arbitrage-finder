// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetByBookmakerIdQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetByBookmakerIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetByBookmakerIdQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository;
    using ArbitrageFinder.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="GetByBookmakerIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetByBookmakerIdQuery, Bookmaker}" />
    public class GetByBookmakerIdQueryHandler : IRequestHandler<GetByBookmakerIdQuery, Bookmaker>
    {
        /// <summary>
        /// The bookmaker repository
        /// </summary>
        private readonly IBookmakerRepository bookmakerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetByBookmakerIdQueryHandler"/> class.
        /// </summary>
        /// <param name="bookmakerRepository">The bookmaker repository.</param>
        public GetByBookmakerIdQueryHandler(IBookmakerRepository bookmakerRepository)
        {
            this.bookmakerRepository = bookmakerRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>
        /// Response from the request
        /// </returns>
        /// <exception cref="NotFoundException">The bookmaker with id {request.BookmakerId} wasn't found.</exception>
        public async Task<Bookmaker> Handle(GetByBookmakerIdQuery request, CancellationToken cancellationToken)
        {
            Bookmaker bookmaker = await this.bookmakerRepository.GetAsync(request.BookmakerId, cancellationToken);

            if (bookmaker is null)
            {
                throw new NotFoundException($"The bookmaker with id {request.BookmakerId} wasn't found.");
            }

            return bookmaker;
        }
    }
}