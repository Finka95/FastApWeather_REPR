using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastApiWeather.Contracts.Requests
{
    public class WeatherForecastRequest
    {
        public int Days {get;init;}
    }
}