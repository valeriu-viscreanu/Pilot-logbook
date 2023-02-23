using FlightLog.Models;

public interface IAircraftRepository
{
    IEnumerable<Aircraft> GetAll();
    Aircraft GetById(int id);
    void Add(Aircraft aircraft);
    void Update(Aircraft aircraft);
    void Delete(int id);
}
