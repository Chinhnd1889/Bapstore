using Bapstore.Data.Infrastructure;
using Bapstore.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bapstore.Data.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Post
                        join pt in DbContext.PostTag
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreateAt descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}