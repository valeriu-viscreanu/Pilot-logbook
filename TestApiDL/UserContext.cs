using Microsoft.EntityFrameworkCore;

namespace Smart.TestApi.DataLayer
{
    public class UserContext:DbContext
    {
        public UserContext(): base(SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), "Data Source=LAPTOP-EJ86HI8K\\SQLEXPRESS;Initial Catalog=SmartTest;Integrated Security=True").Options)
        {
        }

        public DbSet<User> users { get; set; }

    }
}
