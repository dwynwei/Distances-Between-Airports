using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistanceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private IAirportService _airportService;

        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet("/airports")]
        public IActionResult getAirports()
        {
            return Ok(_airportService.GetAllAirports());
        }

        [HttpGet("/airport/{iataCode}")]
        public ActionResult<Airport> GetAirportByIataCode(string iataCode)
        {
            var airport = _airportService.GetAirportByIataCode(iataCode.ToUpper());

            if (airport == null)
            {
                return NotFound();
            }

            return Ok(airport);
        }

        [HttpGet("/distance/from={from}&to={to}")]
        public IActionResult CalculateDistance(string from, string to)
        {
            string distance = _airportService.calculateDistanceOfAirports(from, to);

            return Ok(distance);
        }
    }
}
