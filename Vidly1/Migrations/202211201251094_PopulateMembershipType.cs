namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "SignUpFree");
            Sql("INSERT INTO MemberShipeTypes(Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MemberShipeTypes(Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (2,30,1,10)");
            Sql("INSERT INTO MemberShipeTypes(Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (3,90,3,15)");
            Sql("INSERT INTO MemberShipeTypes(Id,SignUpFee,DurationInMonths,DiscountRate) VALUES (4,300,12,20)");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFree", c => c.Short(nullable: false));
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
