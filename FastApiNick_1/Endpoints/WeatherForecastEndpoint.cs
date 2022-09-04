using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastApiWeather.Contracts.Requests;
using FastApiWeather.Contracts.Responses;
using FastApiWeather.Mappers;
using FastApiWeather.Models;
using FastEndpoints;

namespace FastApiWeather.Endpoints
{
    public class WeatherForecastEndpoint : Endpoint<WeatherForecastRequest, WeatherForecastsResponse, WeatherForecastMapper>
    {
        private static readonly string[] summaries =
        {
            "Freezing", "Bracing","Chilly","Cool","Mild","Warm","Balmy", "Hot"
        };

        public ILogger<WeatherForecastEndpoint> _Logger { get; init; }

        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("weather/{days}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(WeatherForecastRequest req, CancellationToken ct)
        {
            _Logger.LogDebug("Retrivering weather for {Days} days", req.Days);
            Console.WriteLine("Hello");

            var forecasts = Enumerable.Range(1, req.Days).Select(index => new WeatherForecast()
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20,30),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();

            var response = new WeatherForecastsResponse
            {
                Forecasts = forecasts.Select(Map.FromEntity)
            };

            await SendAsync(response, cancellation: ct);
        }
    }
}