namespace FlightLog.Models;

public class FlightLogDatabase
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string FlightsCollectionName { get; set; } = null!;
    public string AircraftCollectionName { get; set; } = null!;
    public string UserCollectionName { get; set; } = null!;
}