using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Interfaces;
namespace SomalilandWeatherForecast.Api
{
    internal class Constants:INNTrain
    {
        static string url = "https://weatherapi.com";

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

            public Coordinate()
            {
            }
        }
        

       public enum WeatherParams
        {
         minimum_temperature,
         maximum_temperature,
         humidity,
         precipitation,
         wind_speed,
         wind_blow_angle,
        }

        public string DataScrapper(string url)
        {
            throw new NotImplementedException();
        }
    }
}
