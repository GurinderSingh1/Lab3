namespace PhoneApplicaion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitailClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerId = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                        Url = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        Founded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(),
                        ManufacturerId = c.Int(nullable: false),
                        msrp = c.Double(nullable: false),
                        Screensize = c.Double(nullable: false),
                        DateReleased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PhoneId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId, cascadeDelete: true)
                .Index(t => t.ManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Phones", new[] { "ManufacturerId" });
            DropTable("dbo.Phones");
            DropTable("dbo.Manufacturers");
        }
    }
}
