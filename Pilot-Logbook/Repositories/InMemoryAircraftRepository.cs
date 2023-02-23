using System.Collections.Generic;
using System.Linq;

namespace FlightLog.Models
{
    public class InMemoryAircraftRepository
    {
        private readonly List<Aircraft> _aircrafts;

        public InMemoryAircraftRepository()
        {
            _aircrafts = new List<Aircraft>
            {
                new Aircraft { Registration = "G-ABCD", Name = "Cessna 172", Type = "Single Engine Piston" },
                new Aircraft { Registration = "G-EFGH", Name = "Piper PA-28 Cherokee", Type = "Single Engine Piston" },
                new Aircraft { Registration = "G-IJKL", Name = "Cessna 152", Type = "Single Engine Piston" },
            };
        }

        public List<Aircraft> GetAll()
        {
            return _aircrafts.ToList();
        }

        public Aircraft GetByRegistration(string registration)
        {
            return _aircrafts.SingleOrDefault(a => a.Registration == registration);
        }

        public void Add(Aircraft aircraft)
        {
            _aircrafts.Add(aircraft);
        }

        public void Update(Aircraft aircraft)
        {
            var existingAircraft = _aircrafts.SingleOrDefault(a => a.Registration == aircraft.Registration);
            if (existingAircraft != null)
            {
                existingAircraft.Name = aircraft.Name;
                existingAircraft.Type = aircraft.Type;
            }
        }

        public void Delete(string registration)
        {
            var aircraftToDelete = _aircrafts.SingleOrDefault(a => a.Registration == registration);
            if (aircraftToDelete != null)
            {
                _aircrafts.Remove(aircraftToDelete);
            }
        }
    }
}
