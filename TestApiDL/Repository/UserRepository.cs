using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart.TestApi.DataLayer
{
    public interface IUserRepository
    { 
    }

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
