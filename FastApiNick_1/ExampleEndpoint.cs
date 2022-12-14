using System;
using FastEndpoints;

namespace FastApiWeather
{
    public class ExampleEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("example");
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new
            {
                message = "Hello World"
            }, cancellation: ct);
        }
    }
}