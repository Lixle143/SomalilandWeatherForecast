using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Interfaces;
using HtmlAgilityPack;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using Newtonsoft.Json;
namespace SomalilandWeatherForecast.Api
{
    internal class DataScrapper : IDataScrapper
    {
        public async Task<String> ScrapData(String url)
        {
            var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await client.SendAsync(request);
            if(!response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.StatusCode.ToString());
            }

            var body = await response.Content.ReadAsStringAsync();
            var result = await request.Content.ReadAsStringAsync(); // From the URL query code above 
            return result;
            // dynamic weather = JsonConvert.DeserializeObject(result);
        }

        public async void  ConvertData2CSVAsync<T>(String data , List<T>records)
        {
            using(StreamWriter sw = new StreamWriter(data))
            using(CsvWriter csv_write = new CsvWriter(sw , CultureInfo.InvariantCulture))
            {
                csv_write.WriteRecords(records);
            }
        }

    
    }
}
