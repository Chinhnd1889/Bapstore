using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface IOrderRepository : IRepository<Order> { }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}