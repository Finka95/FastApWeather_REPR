using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastApiWeather.Models;
using FastApiWeather.Contracts.Requests;
using FastApiWeather.Contracts.Responses;
using FastEndpoints;

namespace FastApiWeather.Mappers
{
    public class WeatherForecastMapper : Mapper<WeatherForecastRequest, WeatherForecastResponse, WeatherForecast>
    {
        public override WeatherForecastResponse FromEntity(WeatherForecast e)
        {
            return new WeatherForecastResponse
            {
                Date = e.Date,
                Summary = e.Summary,
                TemperatureC = e.TemperatureC,
                TemperatureF = e.TemperatureF
            };
        }
    }
}