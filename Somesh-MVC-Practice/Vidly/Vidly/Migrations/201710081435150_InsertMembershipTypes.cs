namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO membershiptypes (SignUpFee,Months,Discount) VALUES (0,0,0)");
            Sql("INSERT INTO membershiptypes (SignUpFee,Months,Discount) VALUES (30,1,10)");
            Sql("INSERT INTO membershiptypes (SignUpFee,Months,Discount) VALUES (90,3,15)");
            Sql("INSERT INTO membershiptypes (SignUpFee,Months,Discount) VALUES (300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
