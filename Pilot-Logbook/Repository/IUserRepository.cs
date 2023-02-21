namespace FlightLog.Repoitory
{
    using FlightLog.Models;
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
        Task<User> AddUserAsync(User signupModel);
    }
}