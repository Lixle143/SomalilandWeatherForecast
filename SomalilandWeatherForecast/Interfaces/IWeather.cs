using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Api;
namespace SomalilandWeatherForecast.Interfaces
{
    internal interface IWeather
    {
        string weather_parameter { get; set; }

        string get_weather(string weather);

    }

}
