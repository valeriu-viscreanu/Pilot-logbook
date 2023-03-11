using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FlightLog.Models
{
    public class Aircraft: IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Registration { get; set; }
    }
}