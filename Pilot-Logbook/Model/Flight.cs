namespace FlightLog.Models
{
    public class Flight: IEntity
    {
        public string Id { get; set; }
        public string AircraftRegistration  { get; set; }
        public DateTime TakeoffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public string[] Pilots { get; set; }
    }
}
