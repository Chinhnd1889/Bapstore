namespace Bapstore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Error",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Order", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Order", "CreatedBy", c => c.String());
            AddColumn("dbo.Product", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Product", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Product", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Product", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategory", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.ProductCategory", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategory", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.ProductCategory", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Page", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Page", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Page", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Page", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Post", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.Post", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Post", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Post", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategory", "CreatedAt", c => c.DateTime());
            AddColumn("dbo.PostCategory", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategory", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.PostCategory", "UpdatedBy", c => c.String(maxLength: 256));
            DropColumn("dbo.Order", "CreateAt");
            DropColumn("dbo.Order", "CreateBy");
            DropColumn("dbo.Product", "CreateAt");
            DropColumn("dbo.Product", "CreateBy");
            DropColumn("dbo.Product", "UpdateAt");
            DropColumn("dbo.Product", "UpdateBy");
            DropColumn("dbo.ProductCategory", "CreateAt");
            DropColumn("dbo.ProductCategory", "CreateBy");
            DropColumn("dbo.ProductCategory", "UpdateAt");
            DropColumn("dbo.ProductCategory", "UpdateBy");
            DropColumn("dbo.Page", "CreateAt");
            DropColumn("dbo.Page", "CreateBy");
            DropColumn("dbo.Page", "UpdateAt");
            DropColumn("dbo.Page", "UpdateBy");
            DropColumn("dbo.Post", "CreateAt");
            DropColumn("dbo.Post", "CreateBy");
            DropColumn("dbo.Post", "UpdateAt");
            DropColumn("dbo.Post", "UpdateBy");
            DropColumn("dbo.PostCategory", "CreateAt");
            DropColumn("dbo.PostCategory", "CreateBy");
            DropColumn("dbo.PostCategory", "UpdateAt");
            DropColumn("dbo.PostCategory", "UpdateBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PostCategory", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategory", "UpdateAt", c => c.DateTime());
            AddColumn("dbo.PostCategory", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategory", "CreateAt", c => c.DateTime());
            AddColumn("dbo.Post", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Post", "UpdateAt", c => c.DateTime());
            AddColumn("dbo.Post", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Post", "CreateAt", c => c.DateTime());
            AddColumn("dbo.Page", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Page", "UpdateAt", c => c.DateTime());
            AddColumn("dbo.Page", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Page", "CreateAt", c => c.DateTime());
            AddColumn("dbo.ProductCategory", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategory", "UpdateAt", c => c.DateTime());
            AddColumn("dbo.ProductCategory", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.ProductCategory", "CreateAt", c => c.DateTime());
            AddColumn("dbo.Product", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Product", "UpdateAt", c => c.DateTime());
            AddColumn("dbo.Product", "CreateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Product", "CreateAt", c => c.DateTime());
            AddColumn("dbo.Order", "CreateBy", c => c.String());
            AddColumn("dbo.Order", "CreateAt", c => c.DateTime());
            DropColumn("dbo.PostCategory", "UpdatedBy");
            DropColumn("dbo.PostCategory", "UpdatedAt");
            DropColumn("dbo.PostCategory", "CreatedBy");
            DropColumn("dbo.PostCategory", "CreatedAt");
            DropColumn("dbo.Post", "UpdatedBy");
            DropColumn("dbo.Post", "UpdatedAt");
            DropColumn("dbo.Post", "CreatedBy");
            DropColumn("dbo.Post", "CreatedAt");
            DropColumn("dbo.Page", "UpdatedBy");
            DropColumn("dbo.Page", "UpdatedAt");
            DropColumn("dbo.Page", "CreatedBy");
            DropColumn("dbo.Page", "CreatedAt");
            DropColumn("dbo.ProductCategory", "UpdatedBy");
            DropColumn("dbo.ProductCategory", "UpdatedAt");
            DropColumn("dbo.ProductCategory", "CreatedBy");
            DropColumn("dbo.ProductCategory", "CreatedAt");
            DropColumn("dbo.Product", "UpdatedBy");
            DropColumn("dbo.Product", "UpdatedAt");
            DropColumn("dbo.Product", "CreatedBy");
            DropColumn("dbo.Product", "CreatedAt");
            DropColumn("dbo.Order", "CreatedBy");
            DropColumn("dbo.Order", "CreatedAt");
            DropTable("dbo.Error");
        }
    }
}
