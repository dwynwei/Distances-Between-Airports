using Business.Abstract;
using DAL.Abstract;
using Helper.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AirportService : IAirportService
    {

        private readonly IAirportRepository _airportRepository;
        private ICalculation _calculation;

        public AirportService(IAirportRepository airportRepository, ICalculation calculation)
        {
            _airportRepository = airportRepository;
            _calculation = calculation;
        }

        public string calculateDistanceOfAirports(string from, string to)
        {
            return _calculation.calculateDistance(from, to);
        }

        public Airport GetAirportByIataCode(string iataCode)
        {
            return _airportRepository.GetLatLongByIataCode(iataCode);
        }

        public IEnumerable<Airport> GetAllAirports()
        {
            return _airportRepository.getAllAirports();
        }
    }
}
