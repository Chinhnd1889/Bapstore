using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface IErrorRepository : IRepository<Error> { }

    public class ErrorRepository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}