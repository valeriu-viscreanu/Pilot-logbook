using Logbook.DataLayer;

namespace Logbook.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepository<User> userAccountRepository;
        private readonly IRepository<Flights> flighRepository;
        private readonly IRepository<AircraftType> aircraftTypeRepository;
        private readonly IRepository<Aircraft> aircraftRepository;


        private readonly LogbookContext logbookContext;

        public UnitOfWork()
        {
                  logbookContext = new LogbookContext();
        }
        public void Commit()
        {
            logbookContext.SaveChanges();
        }

        public void Dispose()
        {
            logbookContext.Dispose();
        }


        public IRepository<User> Users
        {
            get
            {
               return userAccountRepository ??  new GenericRepository<User>(logbookContext);
            }
        }


        public IRepository<Flights> Flights
        {
            get
            {
                return flighRepository ?? new GenericRepository<Flights>(logbookContext);
            }
        }


        public IRepository<Aircraft> Aircrafts
        {
            get
            {
                return aircraftRepository ?? new GenericRepository<Aircraft>(logbookContext);
            }
        }


        public IRepository<AircraftType> AircraftTypes
        {
            get
            {
                return aircraftTypeRepository ?? new GenericRepository<AircraftType>(logbookContext);
            }
        }
    }
}
