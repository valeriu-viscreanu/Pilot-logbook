using FlightLog.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly IFlightRepository flightRepository;

        public FlightsController(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return flightRepository.GetAll().Select(f => new Flight
            {
                Aircraft = new Aircraft
                {
                    Name = f.Aircraft.Name,
                    Type = f.Aircraft.Type,
                    Registration = f.Aircraft.Registration
                },
                LandingTime = f.LandingTime,
                Pilots = f.Pilots,
                TakeoffTime = f.TakeoffTime
            });
        }
    }
}
