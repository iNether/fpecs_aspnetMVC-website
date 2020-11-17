namespace aspnet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (3, 75, 3, 15)");
            Sql("INSERT INTO MemberShipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) VALUES (4, 250, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
