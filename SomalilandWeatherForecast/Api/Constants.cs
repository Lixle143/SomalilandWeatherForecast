using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SomalilandWeatherForecast.Api
{
    internal class Constants
    {
        static string historical_data = "41056e82a947f01076f2a4c54a5cfba9";
        static string normal = "41056e82a947f01076f2a4c54a5cfba9";
        string start_date = "";
        string end_date = " ";

        
        struct Coordinate
        {
            string maroodijeeh = "maroodijeeh";
            string sahil = "saahil";
            string sool = "sool";
            string sanaag = "sanaag";
            string awdal = "awdal";
            string togdher = "togdher";
            string gabilay = "gabilay";
            string baki = "baki";
            string ainabo = "ainabo";
            string zeila = "zeila";
            string buhodle = "buhodle";

            enum Region
            {
                hargeisa,
                borama,
                berbera,
                burao,
                erigabo,
                lasanod,
            }

            public Coordinate(string latitude , string longtitude)
            {
                this.latitude = latitude;
                this.longtitude = longtitude;
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
