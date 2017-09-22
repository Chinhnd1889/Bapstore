namespace Bapstore.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        BapstoreDbContext _dbContext;

        public BapstoreDbContext Init()
        {
            return _dbContext ?? (_dbContext = new BapstoreDbContext());
        }

        protected override void DisposeCore()
        {
            if(_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
