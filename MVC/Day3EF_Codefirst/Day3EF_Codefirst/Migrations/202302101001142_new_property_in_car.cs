namespace Day3EF_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new_property_in_car : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblCar", "CarCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblCar", "CarCost");
        }
    }
}
