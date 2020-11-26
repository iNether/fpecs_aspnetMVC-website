namespace aspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class facebookOAuth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MyProperty");
        }
    }
}
