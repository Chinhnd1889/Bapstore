using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface ISliceRepository : IRepository<Slice> { }

    public class SliceRepository : RepositoryBase<Slice>, ISliceRepository
    {
        public SliceRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
