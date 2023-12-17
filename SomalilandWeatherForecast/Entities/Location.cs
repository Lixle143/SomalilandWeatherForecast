using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomalilandWeatherForecast.Api;
namespace SomalilandWeatherForecast.Entities
{
    internal class Location
    {
        public Location()
        {

        }

        public string City { set; get; }

        public string Coordinate {  set; get; }

    }
}
