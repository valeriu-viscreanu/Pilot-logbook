namespace Smart.TestApi.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IRepository<User> userAccountRepository;
        private readonly UserContext userContext;

        public UnitOfWork()
        {
                  userContext = new UserContext();
        }
        public void Commit()
        {
            userContext.SaveChanges();
        }

        public void Dispose()
        {
            userContext.Dispose();
        }


        public IRepository<User> Users
        {
            get
            {
               return userAccountRepository ??  new GenericRepository<User>(userContext);
            }
        }
    }
}
