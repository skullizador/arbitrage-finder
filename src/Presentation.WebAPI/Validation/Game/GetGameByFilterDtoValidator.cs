// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetGameByFilterDtoValidator.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// GetGameByFilterDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ArbitrageFinder.Presentation.WebAPI.Validation.Game
{
    using ArbitrageFinder.Presentation.WebAPI.Dtos.Input.Game;
    using FluentValidation;

    /// <summary>
    /// <see cref="GetGameByFilterDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetGameByFilterDto}" />
    public class GetGameByFilterDtoValidator : AbstractValidator<GetGameByFilterDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameByFilterDtoValidator"/> class.
        /// </summary>
        public GetGameByFilterDtoValidator()
        {
            this.RuleFor(p => p.StartDate)
                .NotEqual(default(DateTime))
                    .WithMessage("The StartDate shouldn't have the defautl value.")
                .LessThan(p => p.EndDate)
                    .WithMessage("The StartDate shouldn't be higher than the EndDate.");

            this.RuleFor(p => p.EndDate)
                .NotEqual(default(DateTime))
                    .WithMessage("The EndDate shouldn't have the default value.")
                .LessThan(p => p.EndDate)
                    .WithMessage("The EndDate shouldn't be lower than the StartDate.");
        }
    }
}