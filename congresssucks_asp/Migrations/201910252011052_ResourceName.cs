namespace congresssucks_asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResourceName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resources", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resources", "Name");
        }
    }
}
