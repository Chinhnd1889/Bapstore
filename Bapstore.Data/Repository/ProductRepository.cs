using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;

namespace Bapstore.Data.Repository
{
    public interface IProductRepository : IRepository<Product> { }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
