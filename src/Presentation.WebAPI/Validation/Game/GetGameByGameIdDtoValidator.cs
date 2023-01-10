// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByGameIdDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByGameIdDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Game
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Game;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetGameByGameIdDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetGameByGameIdDto}" />
    public class GetGameByGameIdDtoValidator : AbstractValidator<GetGameByGameIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameByGameIdDtoValidator"/> class.
        /// </summary>
        public GetGameByGameIdDtoValidator()
        {
            this.RuleFor(p => p.GameId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The GameId shouldn't have the default value.");
        }
    }
}