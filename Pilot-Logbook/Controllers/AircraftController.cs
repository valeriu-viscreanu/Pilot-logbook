using FlightLog.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightLog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AircraftController : ControllerBase
    {
        private readonly IAircraftRepository aircraftRepository;

        public AircraftController(IAircraftRepository aircraftRepository)
        {
            this.aircraftRepository = aircraftRepository;
        }

        [HttpGet]
        public IEnumerable<Aircraft> Get()
        {
            return this.aircraftRepository.GetAll();
        }

        [HttpGet("{registration}")]
        public IActionResult Get(string registration)
        {
            var aircraft = aircraftRepository.GetByRegistration(registration);
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
            aircraftRepository.Add(aircraft);
            return CreatedAtAction(nameof(Get), new { registration = aircraft.Registration }, aircraft);
        }

        // [HttpPut("{registration}")]
        // public IActionResult Put(string registration, [FromBody] Aircraft aircraft)
        // {
        //     if (aircraft == null || aircraft.Registration != registration)
        //     {
        //         return BadRequest();
        //     }
        //     var existingAircraft = _aircrafts.Find(a => a.Registration == registration);
        //     if (existingAircraft == null)
        //     {
        //         return NotFound();
        //     }
        //     existingAircraft.Name = aircraft.Name;
        //     existingAircraft.Type = aircraft.Type;
        //     return NoContent();
        // }

        // [HttpDelete("{registration}")]
        // public IActionResult Delete(string registration)
        // {
        //     var aircraft = _aircrafts.Find(a => a.Registration == registration);
        //     if (aircraft == null)
        //     {
        //         return NotFound();
        //     }
        //     _aircrafts.Remove(aircraft);
        //     return NoContent();
        // }
    }
}