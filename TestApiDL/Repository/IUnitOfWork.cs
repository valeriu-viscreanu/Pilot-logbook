using Microsoft.EntityFrameworkCore;
using System;

namespace Smart.TestApi.DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        void Commit();
    }
}

