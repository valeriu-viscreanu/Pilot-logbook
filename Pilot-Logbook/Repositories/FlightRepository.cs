using FlightLog.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightLog
{
    public class FlightRepository : BaseRepository<Flight>, IFlightRepository
    {
        public FlightRepository(IOptions<FlightLogDatabase> databaseSettings) : base(databaseSettings)
        {
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Flight GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
