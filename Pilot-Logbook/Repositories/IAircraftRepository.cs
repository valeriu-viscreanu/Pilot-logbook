using FlightLog.Models;

public interface IAircraftRepository
{
    IEnumerable<Aircraft> GetAll();
    Aircraft GetByRegistration(string registration);
    void Add(Aircraft aircraft);
    void Update(Aircraft aircraft);
    void Delete(int id);
}
