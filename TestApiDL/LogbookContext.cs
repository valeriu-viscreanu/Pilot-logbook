using Microsoft.EntityFrameworkCore;

namespace Logbook.DataLayer
{
    public class LogbookContext:DbContext
    {
        public LogbookContext(): base(SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), "Data Source=LAPTOP-EJ86HI8K\\SQLEXPRESS;Initial Catalog=SmartTest;Integrated Security=True").Options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Flights> Flight { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<AircraftType> AircraftType { get; set; }

    }
}
