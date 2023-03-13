using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IAirportRepository
    {
        public IEnumerable<Airport> getAllAirports();
        public Airport GetLatLongByIataCode(string iataCode);
    }
}
