using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FlightLog.Models
{
    public class AircraftRepository: IAircraftRepository
    {
        private IMongoCollection<Aircraft>  _aircrafts = new(); 
         public AircraftRepository(IOptions<FlightsDatabaseSettings> flightsDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            flightsDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                flightsDatabaseSettings.Value.DatabaseName);

            _aircrafts = mongoDatabase.GetCollection<Aircraft>(
                flightsDatabaseSettings.Value.FlightsCollectionName);
        }


        public Aircraft GetByRegistration(string registration) => 
                 _aircrafts.Find(x => x.Registration == registration).FirstOrDefaultAsync().Result;

        public IEnumerable<Aircraft> GetAll() => _aircrafts.Find(_ => true).ToListAsync().Result; 
        
        public void Add(Aircraft aircraft) => _aircrafts.InsertOneAsync(aircraft);

        public void Update(Aircraft aircraft) =>  throw new NotImplementedException(); 


        public void Delete(int id) =>  throw new NotImplementedException(); 
    }
}
