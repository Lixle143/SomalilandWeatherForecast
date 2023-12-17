using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomalilandWeatherForecast.Api
{
    internal interface IDataScrapper
    {
        // private string header = "";

        public string ConvertData2CSV(Dictionary<string  ,string>data);
        public void ParseHTML(string html_data);
        //string Header { get; set; }
    }
}
