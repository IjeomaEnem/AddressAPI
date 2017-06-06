namespace AddressAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerTbl2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "MeterNo", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Customers", "MeterNo");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "MeterNo", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Customers", "MeterNo");
        }
    }
}
