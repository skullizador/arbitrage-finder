// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetAllBookmakersQueryHandler.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetAllBookmakersQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Queries.Bookmaker.GetAllBookmakersQuery
{
    using System.Threading;
    using System.Threading.Tasks;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker;
    using ArbitrageFinder.Domain.AggregateModels.Bookmaker.Repository;
    using MediatR;

    /// <summary>
    /// <see cref="GetAllBookmakersQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetAllBookmakersQuery, IEnumerable{Bookmaker}}" />
    public class GetAllBookmakersQueryHandler : IRequestHandler<GetAllBookmakersQuery, IEnumerable<Bookmaker>>
    {
        /// <summary>
        /// The bookmaker repository
        /// </summary>
        private readonly IBookmakerRepository bookmakerRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllBookmakersQueryHandler"/> class.
        /// </summary>
        /// <param name="bookmakerRepository">The bookmaker repository.</param>
        public GetAllBookmakersQueryHandler(IBookmakerRepository bookmakerRepository)
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
        public async Task<IEnumerable<Bookmaker>> Handle(GetAllBookmakersQuery request, CancellationToken cancellationToken)
        {
            List<Bookmaker> bookmakers = await this.bookmakerRepository.GetAllAsync(cancellationToken);

            return bookmakers;
        }
    }
}