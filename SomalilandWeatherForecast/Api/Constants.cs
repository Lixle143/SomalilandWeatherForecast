using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomalilandWeatherForecast.Api
{
    internal class Constants
    {
        static string url = "https://weatherapi.com";
        enum Regions
        {
            string maroodijeeh;
            string sahil;
            string sool;
            string sanaag;
            string awdal;
            string togdher;
        }
        
        enum Coordinates
        {
            string hargeisa;
            string borama;
            string berbera;
            string burao;
            string erigabo;
            string lasanod;
        }

        enum WeatherParameters
        {
         int minimum_temperature;
         int maximum_temperature;
         int humidity;
        }
    }
}
