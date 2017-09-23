using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline> { }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>, ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
