using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastEndpoints;
using FastApiWeather.Contracts.Requests;
using FluentValidation;

namespace FastApiNick_1.Validators
{
    public class WeatherForecastRetrievalValidator : Validator<WeatherForecastRequest>
    {
        public WeatherForecastRetrievalValidator()
        {
            RuleFor(x => x.Days)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Weather forecast days must be at least 1")
                .LessThanOrEqualTo(14)
                .WithMessage("Weather forecast can't be retrieved past 14 days");
        }
    }
}