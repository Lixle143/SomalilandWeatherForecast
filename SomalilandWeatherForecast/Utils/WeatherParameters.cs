using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Api;
namespace SomalilandWeatherForecast.Entities
{
    internal class WeatherParameters
    {

        public WeatherParameters()
        { 

        }
        public int max_temperature { get; set; }

        public int min_temperature { get; set; }
        public int humidity { get; set;}
        public int wind_speed { get; set;}

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
