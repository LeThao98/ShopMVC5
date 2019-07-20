namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.PostCategories", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "UpdatedTime", c => c.DateTime());
            AddColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCategories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Posts", "CreatedTime", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "UpdatedTime", c => c.DateTime());
            AddColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.Posts", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Status");
            DropColumn("dbo.Posts", "MetaDescription");
            DropColumn("dbo.Posts", "MetaKeyword");
            DropColumn("dbo.Posts", "UpdatedBy");
            DropColumn("dbo.Posts", "UpdatedTime");
            DropColumn("dbo.Posts", "CreatedBy");
            DropColumn("dbo.Posts", "CreatedTime");
            DropColumn("dbo.PostCategories", "Status");
            DropColumn("dbo.PostCategories", "MetaDescription");
            DropColumn("dbo.PostCategories", "MetaKeyword");
            DropColumn("dbo.PostCategories", "UpdatedBy");
            DropColumn("dbo.PostCategories", "UpdatedTime");
            DropColumn("dbo.PostCategories", "CreatedBy");
            DropColumn("dbo.PostCategories", "CreatedTime");
            DropTable("dbo.Errors");
        }
    }
}
