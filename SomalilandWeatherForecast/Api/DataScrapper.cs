using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Interfaces;

namespace SomalilandWeatherForecast.Api
{
    internal class DataScrapper : IDataScrapper
    {
        static async Task ScrapData()
        {

        }

        public string ConvertData2CSV(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public void ParseHTML(string html_data)
        {
            throw new NotImplementedException();
        }
    }
}
