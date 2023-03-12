
using FlightLog.ViewModel;
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
        public IEnumerable<ViewModel.Aircraft> Get()
        {
            var aircrafts = aircraftRepository.GetAll();
            var r = new List<ViewModel.Aircraft>();
            return  aircrafts.Select(ac => new ViewModel.Aircraft
            {
                Name = ac.Name,
                Registration = ac.Registration,
                Type = ac.Type
            }).ToList();
        }

        [HttpGet("{registration}")]
        public IActionResult Get(string registration)
        {
            var aircraft = aircraftRepository.GetByRegistration(registration);
            if (aircraft == null)
            {
                return NotFound();
            }
            return Ok(new ViewModel.Aircraft
            {
                Name = aircraft.Name,
                Registration = aircraft.Registration,
                Type = aircraft.Type
            });
        }

        [HttpPost]
        public IActionResult Post([FromBody] ViewModel.Aircraft aircraftVM)
        {
            if (aircraftVM == null)
            {
                return BadRequest();
            }
            aircraftRepository.Add(new Models.Aircraft
            {
                Name = aircraftVM.Name,
                Registration = aircraftVM.Registration,
                Type = aircraftVM.Type
            });
            return CreatedAtAction(nameof(Get), new { registration = aircraftVM.Registration }, aircraftVM);
        }

        //[HttpPut("{registration}")]
        //public IActionResult Put(string registration, [FromBody] Aircraft aircraft)
        //{
        //    if (aircraft == null || aircraft.Registration != registration)
        //    {
        //        return BadRequest();
        //    }
        //    var existingAircraft = _aircrafts.Find(a => a.Registration == registration);
        //    if (existingAircraft == null)
        //    {
        //        return NotFound();
        //    }
        //    existingAircraft.Name = aircraft.Name;
        //    existingAircraft.Type = aircraft.Type;
        //    return NoContent();
        //}

        //[HttpDelete("{registration}")]
        //public IActionResult Delete(string registration)
        //{
        //    var aircraft = _aircrafts.Find(a => a.Registration == registration);
        //    if (aircraft == null)
        //    {
        //        return NotFound();
        //    }
        //    _aircrafts.Remove(aircraft);
        //    return NoContent();
        //}
    }
}