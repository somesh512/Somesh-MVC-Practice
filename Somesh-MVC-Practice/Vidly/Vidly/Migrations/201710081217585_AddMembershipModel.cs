namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SignUpFee = c.Short(nullable: false),
                        Months = c.Byte(nullable: false),
                        Discount = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Customers", "IsSubscribedToNewsLetter", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "MembershipType_ID", c => c.Int());
            CreateIndex("dbo.Customers", "MembershipType_ID");
            AddForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_ID", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_ID" });
            DropColumn("dbo.Customers", "MembershipType_ID");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "IsSubscribedToNewsLetter");
            DropTable("dbo.MembershipTypes");
        }
    }
}
