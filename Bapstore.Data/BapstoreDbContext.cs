using Bapstore.Model.Models;
using System.Data.Entity;

namespace Bapstore.Data
{
    public class BapstoreDbContext : DbContext
    {
        public BapstoreDbContext() : base("BapstoreConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footer { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuGroup> MenuGroup { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<PostTag> PostTag { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductTag> ProductTag { get; set; }
        public DbSet<Slice> Slice { get; set; }
        public DbSet<SupportOnline> SupportOnline { get; set; }
        public DbSet<SystemConfig> SystemConfig { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistic { get; set; }
        public DbSet<Error> Error { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
