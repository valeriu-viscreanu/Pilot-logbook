using FlightLog.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightLog
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IMongoCollection<Flight> _flights;

        public FlightRepository(IOptions<FlightLogDatabase> flightsDatabaseSettings)
        {
            var mongoClient = new MongoClient(
            flightsDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                flightsDatabaseSettings.Value.DatabaseName);

            _flights = mongoDatabase.GetCollection<Flight>(
                flightsDatabaseSettings.Value.FlightsCollectionName);
        }

        public Flight GetById(int id) =>  _flights.Find(x => x.Id == id).FirstOrDefaultAsync().Result;

        public IEnumerable<Flight> GetAll() => _flights.Find(_ => true).ToListAsync().Result;        

        public void Add(Flight flight) => _flights.InsertOneAsync(flight);
        
        public void Update(Flight flight) => throw new NotImplementedException();

        public void Delete(int id) => throw new NotImplementedException();
    }
}
