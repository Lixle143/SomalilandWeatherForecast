using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Interfaces;
using SomalilandWeatherForecast.Entities;
namespace SomalilandWeatherForecast.Api
{
    internal class Constants:Location , INNTrain
    {
        static string historical_data = "41056e82a947f01076f2a4c54a5cfba9";
        static string normal = "41056e82a947f01076f2a4c54a5cfba9";
        string start_date = "";
        string end_date = " ";

        
        public long loss { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        struct NNParams
        {
            int weight;
            int loss;
            string optimizer;
        }
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
         int minimum_temperature;
         int maximum_temperature;
         int humidity;
         int precipitation;
         int wind_speed;
         int wind_blow_angle;
        }

        public string DataScrapper(string url)
        {
            try
            {

            }
            catch(HttpIOException)
            {
                Console.WriteLine("HTTP IO exception ... ");
            }
            catch (IOException)
            {
                Console.WriteLine("IO Exception caught...")
            }
            throw new NotImplementedException();
        }
    }
}
