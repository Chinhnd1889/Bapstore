using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bapstore.Data.Repository
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) 
            : base(dbFactory) { }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategory.Where(x => x.Alias == alias);
        }
    }
}
