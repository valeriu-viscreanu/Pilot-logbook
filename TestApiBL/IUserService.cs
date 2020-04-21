using Logbook.DataLayer;
using System.Collections.Generic;

namespace Logbook.Applicationlayer
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void SaveUser(User user);
        void Delete(User user);
        void Update(User user);

    }
}
