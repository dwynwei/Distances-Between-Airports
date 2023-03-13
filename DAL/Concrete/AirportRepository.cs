using DAL.Abstract;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AirportRepository : IAirportRepository
    {
        private readonly IEnumerable<Airport> _airports;

        public AirportRepository()
        {
            string url = "https://raw.githubusercontent.com/algolia/datasets/master/airports/airports.json";

            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(url).Result;
                _airports = JsonConvert.DeserializeObject<List<Airport>>(json);
            }
        }

        public IEnumerable<Airport> getAllAirports()
        {
            return _airports;
        }

        public Airport GetLatLongByIataCode(string iataCode)
        {
            return _airports.FirstOrDefault(a => a.IataCode == iataCode);
        }
    }
}
