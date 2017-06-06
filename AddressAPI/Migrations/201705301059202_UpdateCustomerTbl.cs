namespace AddressAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MobilePhoneNo", c => c.String());
            DropColumn("dbo.Customers", "Amount");
            DropColumn("dbo.Customers", "Unit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Unit", c => c.String());
            AddColumn("dbo.Customers", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Customers", "MobilePhoneNo");
        }
    }
}
