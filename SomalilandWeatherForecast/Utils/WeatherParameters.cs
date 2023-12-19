using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Api;
using SomalilandWeatherForecast.Interfaces;
namespace SomalilandWeatherForecast.Entities
{
    internal class WeatherParameters : IWeather
    {

        public WeatherParameters()
        { 

        }
        public int max_temperature { get; set; }

        public int min_temperature { get; set; }
        public int humidity { get; set;}
        public int wind_speed { get; set;}
        public string weather_parameter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string get_weather(string weather)
        {
            throw new NotImplementedException();
        }

        struct WeatherSettings
        {

            enum WEATHER_TYPE
            {
                current,
                historical,
            }
        }
    }
}
