using AutoMapper;
using Logbook.DataLayer;
using System.Collections.Generic;
using System.Linq;

namespace Logbook.Applicationlayer
{
    public class UserService: IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Delete(User user)
        {
            var dbUser = unitOfWork.Users.Get(u => u.PIN == user.PIN).First();
            unitOfWork.Users.Delete(dbUser.Id);
            unitOfWork.Commit();
        }

        public IEnumerable<User> GetUsers()
        {
            return unitOfWork.Users.Get();
        }

        public void SaveUser(User user)
        {
            unitOfWork.Users.Add(user);
            unitOfWork.Commit();
        }

        public void Update(User user)
        {
            unitOfWork.Users.Update(user);
            unitOfWork.Commit();
        }
    }
}
