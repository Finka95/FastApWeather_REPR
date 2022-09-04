using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastApiWeather.Contracts.Responses
{
    public class WeatherForecastsResponse
    {
        public IEnumerable<WeatherForecastResponse> Forecasts {get;set;}
    }
}