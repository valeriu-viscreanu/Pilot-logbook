using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace FlightLog.Models
{
    public class BaseRepository<T> where T : class, IEntity
    {
        private readonly IMongoCollection<T> _collection;

        public BaseRepository(IOptions<FlightLogDatabase> databaseSettings)
        {
            var client = new MongoClient(databaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(databaseSettings.Value.DatabaseName);
            _collection = database.GetCollection<T>(typeof(T).Name.ToLowerInvariant() + "s");
        }

        public IEnumerable<T> GetAll()
        {
            return _collection.Find(x => true).ToListAsync().Result;
        }

        public T GetById(string id)
        {
            return _collection.Find(x => x.Id == id).FirstOrDefaultAsync().Result;
        }

        public void Add(T entity)
        {
            _collection.InsertOneAsync(entity).Wait();
        }

        public void Update(T entity)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, entity.Id);
            _collection.ReplaceOneAsync(filter, entity).Wait();
        }

        public void Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            _collection.DeleteOneAsync(filter).Wait();
        }
    }
}
