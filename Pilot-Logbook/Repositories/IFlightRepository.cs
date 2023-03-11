using FlightLog.Models;

namespace FlightLog
{
    public interface IFlightRepository
    {
        Flight GetById(string id);

        IEnumerable<Flight> GetAll();

        void Add(Flight flight);

        void Update(Flight flight);
        
        void Delete(string id);

    }
}