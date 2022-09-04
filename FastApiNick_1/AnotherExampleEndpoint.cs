using FastEndpoints;
using FastApiWeather;

namespace FastApiWeather
{
    public class ExampleEnAnotherExampleEndpoint : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("another/{days}");
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