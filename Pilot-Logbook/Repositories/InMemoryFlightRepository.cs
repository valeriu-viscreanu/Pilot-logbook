using FlightLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightLog
{
    public class InMemoryFlightRepository : IFlightRepository
    {
        private readonly List<Flight> _flights;

        public InMemoryFlightRepository()
        {
            _flights = new List<Flight>();
        }

        public Flight GetById(int id)
        {
            return _flights.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Flight> GetAll()
        {
            return _flights;
        }

        public void Add(Flight flight)
        {
            flight.Id = _flights.Any() ? _flights.Max(f => f.Id) + 1 : 1;
            _flights.Add(flight);
        }

        public void Update(Flight flight)
        {
            var existingFlight = _flights.FirstOrDefault(f => f.Id == flight.Id);
            if (existingFlight != null)
            {
                _flights.Remove(existingFlight);
                _flights.Add(flight);
            }
        }

        public void Delete(int id)
        {
            var existingFlight = _flights.FirstOrDefault(f => f.Id == id);
            if (existingFlight != null)
            {
                _flights.Remove(existingFlight);
            }
        }
    }
}
