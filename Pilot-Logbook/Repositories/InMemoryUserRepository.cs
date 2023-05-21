using FlightLog.Models;
namespace FlightLog.Repository
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly Dictionary<string, User> _users = new Dictionary<string, User>();

        public async Task<User> GetByUsernameAsync(string username)
        {
            if (_users.TryGetValue(username, out var user))
            {
                return await Task.FromResult(user);
            }
            else
            {
                return await Task.FromResult<User>(null);
            }
        }


        public async Task<User> AddUserAsync(User userDTO)
        {
              if (await GetByUsernameAsync(userDTO.Name) != null)
            {
                throw new Exception($"Username {userDTO.Name} already exists");
            }

            var user = new User
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password
            };

            _users.Add(user.Name, user);

            return await Task.FromResult(user);
        }
    }
}