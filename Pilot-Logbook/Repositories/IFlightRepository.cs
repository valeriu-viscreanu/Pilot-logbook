using FlightLog.Models;

namespace FlightLog
{
    public interface IFlightRepository
    {
        Flight GetById(int id);

        IEnumerable<Flight> GetAll();

        void Add(Flight flight);

        void Update(Flight flight);
        
        void Delete(int id);

    }
}