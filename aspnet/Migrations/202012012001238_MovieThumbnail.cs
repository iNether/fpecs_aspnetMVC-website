namespace aspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieThumbnail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "thumbnailLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "thumbnailLink");
        }
    }
}
