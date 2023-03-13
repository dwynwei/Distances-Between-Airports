using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAirportService
    {
        public IEnumerable<Airport> GetAllAirports();
        public Airport GetAirportByIataCode(string iataCode);

        public string calculateDistanceOfAirports(string from, string to);
    }
}
