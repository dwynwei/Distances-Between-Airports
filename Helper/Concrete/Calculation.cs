using DAL.Abstract;
using Helper.Abstract;
using Model;
using System;

namespace Helper
{
    public class Calculation : ICalculation
    {

        private IAirportRepository _airportRepository;

        public Calculation(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public string calculateDistance(string from, string to)
        {
            Airport airportFrom = _airportRepository.GetLatLongByIataCode(from);
            Airport airportTo = _airportRepository.GetLatLongByIataCode(to);

            if(airportFrom == null)
            {
                return $"{from} IATA Kodu Bulunamadı !";
            }

            if(airportTo == null)
            {
                return $"{to} IATA Kodu Bulunamadı !";
            }

            double rlat1 = Math.PI * airportFrom.Latitude / 180;
            double rlat2 = Math.PI * airportTo.Latitude / 180;
            double theta = airportFrom.Longitude - airportFrom.Longitude;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;


            return String.Format("{0:0.00}", (dist * 1.609344)) + " KM";
        }
    }
}
