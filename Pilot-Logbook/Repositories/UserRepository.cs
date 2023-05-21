using FlightLog.Models;
using Microsoft.Extensions.Options;

namespace FlightLog.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IOptions<FlightLogDatabase> databaseSettings) : base(databaseSettings)
        {
        }

        public Task<User> AddUserAsync(User signupModel)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUsernameAsync(string username)
        {
            throw new NotImplementedException();
        }
    }
}