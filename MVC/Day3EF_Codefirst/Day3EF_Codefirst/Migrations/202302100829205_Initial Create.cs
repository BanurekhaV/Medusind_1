namespace Day3EF_Codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCar",
                c => new
                    {
                        CarNo = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        CarModel = c.String(),
                    })
                .PrimaryKey(t => t.CarNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCar");
        }
    }
}
