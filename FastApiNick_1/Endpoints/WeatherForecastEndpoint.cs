using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastApiNick_1.Contracts.Requests;
using FastApiNick_1.Contracts.Responses;
using FastApiNick_1.Models;
using FastEndpoints;

namespace FastApiNick_1.Endpoints
{
    public class WeatherForecastEndpoint : Endpoint<WeatherForecastRequest, WeatherForecastsResponse>
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
                TemperatureC = Random.Shared.Next(-20,55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }).ToArray();

            var response = new WeatherForecastsResponse
            {
                Forecasts = forecasts.Select(x => new WeatherForecastResponse
                {
                    Date = x.Date,
                    TemperatureC = x.TemperatureC,
                    TemperatureF = x.TemperatureF,
                    Summary = x.Summary
                })
            };

            await SendAsync(response, cancellation: ct);
        }
    }
}