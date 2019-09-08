namespace congresssucks_asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ShortPost = c.String(nullable: false),
                        Post = c.String(nullable: false),
                        Tags = c.String(nullable: false),
                        Updated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogPosts");
        }
    }
}
