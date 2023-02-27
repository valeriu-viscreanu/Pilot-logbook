using FlightLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly List<Flight> _flights;
        private readonly IFlightRepository flightRepository;

        public FlightsController(IFlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return flightRepository.GetAll();
        }
    }
}
