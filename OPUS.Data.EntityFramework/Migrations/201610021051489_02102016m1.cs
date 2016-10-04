namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02102016m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinalPlans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FeasibilityId = c.Int(nullable: false),
                        LinkId = c.String(),
                        FromPOCSite = c.String(),
                        ToPOCSite = c.String(),
                        FromCoreId = c.String(),
                        ToCoreId = c.String(),
                        LinkBudget = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InCAttachedFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OHId = c.Int(nullable: false),
                        ProvidedBy = c.String(),
                        FileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InCImps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FinalPlanId = c.Int(nullable: false),
                        FromSiteId = c.String(),
                        FromSiteAddress = c.String(),
                        FromSiteRxPower = c.String(),
                        ToSiteId = c.String(),
                        ToSiteAddress = c.String(),
                        ToSiteRxPower = c.String(),
                        ConfigDetails = c.String(),
                        MUXSwithRouterInfo = c.String(),
                        DeviceDetails = c.String(),
                        CommissionedBy = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OverHeadAttachedFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OHId = c.Int(nullable: false),
                        ProvidedBy = c.String(),
                        FileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OverHeadImps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FinalPlanId = c.Int(nullable: false),
                        FromSiteId = c.String(),
                        FromSiteAddress = c.String(),
                        FromSiteCableId = c.String(),
                        FromSiteOHCoreColor = c.String(),
                        FromSiteRxPower = c.String(),
                        ToSiteId = c.String(),
                        ToSiteAddress = c.String(),
                        ToSiteCableId = c.String(),
                        ToSiteOHCoreColor = c.String(),
                        ToSiteRxPower = c.String(),
                        OTDRDistance = c.Double(nullable: false),
                        SpanLoss = c.Double(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnderGroundAttachedFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UgId = c.Int(nullable: false),
                        ProvidedBy = c.String(),
                        FileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnderGroundImps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        FinalPlanId = c.Int(nullable: false),
                        FromOHType = c.String(),
                        ToOHType = c.String(),
                        FromSiteOHODFInfo = c.String(),
                        PocOHColor = c.String(),
                        ToSiteOHODFInfo = c.String(),
                        ToPOCOHColor = c.String(),
                        OTDRDistance = c.Double(nullable: false),
                        SpanLossDB = c.Double(nullable: false),
                        HasShortPiece = c.Boolean(nullable: false),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnderGroundImps");
            DropTable("dbo.UnderGroundAttachedFiles");
            DropTable("dbo.OverHeadImps");
            DropTable("dbo.OverHeadAttachedFiles");
            DropTable("dbo.InCImps");
            DropTable("dbo.InCAttachedFiles");
            DropTable("dbo.FinalPlans");
        }
    }
}
