using FlightLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightsController : ControllerBase
    {
        private readonly List<Flight> _flights;

        public FlightsController()
        {
            // Initialize some example flights
            _flights = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    Aircraft = new Aircraft
                    {
                        Name = "Boeing 747",
                        Type = "Jet",
                        Registration = "N12345"
                    },
                    TakeoffTime = DateTime.UtcNow,
                    LandingTime = DateTime.UtcNow.AddHours(2),
                    Pilots = new string[] { "John Smith", "Jane Doe" }
                },
                new Flight
                {
                    Id = 2,
                    Aircraft = new Aircraft
                    {
                        Name = "Cessna 172",
                        Type = "Single-Engine",
                        Registration = "N54321"
                    },
                    TakeoffTime = DateTime.UtcNow.AddDays(-1),
                    LandingTime = DateTime.UtcNow.AddDays(-1).AddHours(1),
                    Pilots = new string[] { "Bob Johnson" }
                }
            };
        }

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return _flights;
        }
    }
}
