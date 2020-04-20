using Smart.TestApi.DataLayer;
using System.Collections.Generic;

namespace Smart.TestApi.Applicationlayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void SaveUser(User user);
        void Delete(User user);
        void Update(User user);

    }
}
