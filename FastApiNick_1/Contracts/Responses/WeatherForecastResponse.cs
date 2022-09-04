using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastApiNick_1.Contracts.Responses
{
    public class WeatherForecastResponse
    {
        public DateTime Date {get;set;}
        public int TemperatureC {get;set;}
        public int TemperatureF {get;set;}
        public string? Summary {get;set;}
    }
}