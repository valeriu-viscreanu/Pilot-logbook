using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logbook.DataLayer
{
    public interface ILogbookRepository
    { 
    }

    public class LogbookRepository : GenericRepository<User>, ILogbookRepository
    {
        public LogbookRepository(DbContext context) : base(context)
        {
        }
    }
}
