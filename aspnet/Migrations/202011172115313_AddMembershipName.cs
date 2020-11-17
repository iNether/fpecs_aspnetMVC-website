namespace aspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("UPDATE MemberShipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'Mounthly' WHERE Id = 2");
            Sql("UPDATE MemberShipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
