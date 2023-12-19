using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Api;
using SomalilandWeatherForecast.Interfaces;
namespace SomalilandWeatherForecast.Api
{
    internal class Constants
    {
        public const string API_KEY = "41056e82a947f01076f2a4c54a5cfba9";
        public string url = "https://api.openweathermap.org/data/3.0/onecall?lat=33.44&lon=-94.04&exclude=hourly,daily&appid={API key}";
        string start_date { get; set; }
        string end_date { get; set; }

        public DataScrapper dataScrap = new DataScrapper();

        public String printWeatherData()
        {
            var records = new List<String>
            {

            };
            String data = dataScrap.ScrapData(url).ToString();
            dataScrap.ConvertData2CSVAsync( data, records );
            return "";
        }
        
        struct Coordinate
        {
            string hargeysa = "";
            string boorama = "";
            string burco = "";
            string ceerigabo = "";
            string laascanood = "";
            string berbera = "";
            string gabilay = "gabilay";
            string baki = "baki";
            string caynabo = "ainabo";
            string saylac = "zeila";
            string buhodle = "buhodle";

            public Coordinate()
            {
            }

            enum Region
            {
             maroodijeeh,
             sahil,
             sool,
             sanaag,
             awdal,
             togdher,
        }

        }
        

       public class WeatherParams
        {
         int minimum_temperature { get; set; }
         int maximum_temperature { get; set; }
         int humidity { get; set; }
         int precipitation { get; set; }
         int wind_speed { get; set; }
         int wind_blow_angle { get; set; }
        }

        
    }
}
