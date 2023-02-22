using FlightLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftController : ControllerBase
    {
        private readonly List<Aircraft> _aircrafts;

        public AircraftController()
        {
            // Initialize some example aircrafts
            _aircrafts = new List<Aircraft>
            {
                new Aircraft
                {
                    Name = "Boeing 747",
                    Type = "Jet",
                    Registration = "N12345"
                },
                new Aircraft
                {
                    Name = "Cessna 172",
                    Type = "Single-Engine",
                    Registration = "N54321"
                }
            };
        }

        [HttpGet]
        public IEnumerable<Aircraft> Get()
        {
            return _aircrafts;
        }

        [HttpGet("{registration}")]
        public IActionResult Get(string registration)
        {
            var aircraft = _aircrafts.Find(a => a.Registration == registration);
            if (aircraft == null)
            {
                return NotFound();
            }
            return Ok(aircraft);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Aircraft aircraft)
        {
            if (aircraft == null)
            {
                return BadRequest();
            }
            _aircrafts.Add(aircraft);
            return CreatedAtAction(nameof(Get), new { registration = aircraft.Registration }, aircraft);
        }

        [HttpPut("{registration}")]
        public IActionResult Put(string registration, [FromBody] Aircraft aircraft)
        {
            if (aircraft == null || aircraft.Registration != registration)
            {
                return BadRequest();
            }
            var existingAircraft = _aircrafts.Find(a => a.Registration == registration);
            if (existingAircraft == null)
            {
                return NotFound();
            }
            existingAircraft.Name = aircraft.Name;
            existingAircraft.Type = aircraft.Type;
            return NoContent();
        }

        [HttpDelete("{registration}")]
        public IActionResult Delete(string registration)
        {
            var aircraft = _aircrafts.Find(a => a.Registration == registration);
            if (aircraft == null)
            {
                return NotFound();
            }
            _aircrafts.Remove(aircraft);
            return NoContent();
        }
    }
}