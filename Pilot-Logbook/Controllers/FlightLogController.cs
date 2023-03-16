using Microsoft.AspNetCore.Mvc;
using Flight = FlightLog.ViewModel.Flight;

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
                AircraftRegistration = f.AircraftRegistration,
                LandingTime = f.LandingTime,
                Pilots = f.Pilots,
                TakeoffTime = f.TakeoffTime
            });
        }

        [HttpPost]
        public ActionResult Post([FromBody] Flight flightVM)
        {
            if (flightVM == null)
            {
                return BadRequest();
            }
            flightRepository.Add(new Models.Flight
            {
                LandingTime = flightVM.LandingTime,
                TakeoffTime = flightVM.TakeoffTime,
                AircraftRegistration = flightVM.AircraftRegistration,
                Pilots = flightVM.Pilots
            });

            return Ok();

        }
    }
}
