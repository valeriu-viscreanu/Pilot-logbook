using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FlightLog.ViewModel
{
    public class Aircraft
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Registration { get; set; }
    }
}