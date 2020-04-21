using Logbook.DataLayer;
using System;

namespace Logbook.DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Flights> Flights { get; }
        IRepository<Aircraft> Aircrafts { get; }
        IRepository<AircraftType> AircraftTypes { get; }
        void Commit();
    }
}

