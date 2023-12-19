using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomalilandWeatherForecast.Interfaces
{
    internal interface IDataScrapper
    {
        // private string header = "";

        public void ConvertData2CSVAsync<T>(string data , List<T>records);
        public Task<string> ScrapData(string url);
        //string Header { get; set; }
    }
}
