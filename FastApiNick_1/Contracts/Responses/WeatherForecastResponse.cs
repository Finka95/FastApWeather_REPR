using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastApiWeather.Contracts.Responses
{
    public class WeatherForecastResponse
    {
        public DateTime Date {get;set;}
        public int TemperatureC {get;set;}
        public int TemperatureF {get;set;}
        public string? Summary {get;set;}
    }
}