namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _248m3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feasibilities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeasiblityTypeId = c.String(),
                        KamId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        Requestfor = c.String(),
                        Requestdate = c.DateTime(nullable: false),
                        ConnectivityType = c.String(),
                        ConnectionType = c.String(),
                        AddressOfClientLocationA = c.String(),
                        LatitudeOfClientLocationA = c.String(),
                        LongitudeOfClientLocationA = c.String(),
                        AddressOfClientLocationB = c.String(),
                        LatitudeOfClientLocationB = c.String(),
                        LongitudeOfClientLocationB = c.String(),
                        IsExistingInterface = c.String(),
                        ServiceType = c.String(),
                        RequiredCapacityQuantity = c.Int(nullable: false),
                        RequiredCapacityUnit = c.String(),
                        InterfaceType = c.Int(nullable: false),
                        InterfaceTypeUnit = c.String(),
                        InterfaceCategory = c.String(),
                        SubcategoryOfInterfaceCategory = c.Int(nullable: false),
                        LastMileBy = c.String(),
                        LastMileServiceTypeOfLocationA = c.String(),
                        LastMileImplementationTypeOfLocationA = c.String(),
                        LastMileServiceTypeOfLocationB = c.String(),
                        LastMileImplementationTypeOfLocationB = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feasibilities");
        }
    }
}
