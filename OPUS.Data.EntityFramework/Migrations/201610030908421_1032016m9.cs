namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1032016m9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InCImps", "FromSiteCableId", c => c.String());
            AddColumn("dbo.InCImps", "FromSiteOHCoreColor", c => c.String());
            AddColumn("dbo.InCImps", "ToSiteCableId", c => c.String());
            AddColumn("dbo.InCImps", "ToSiteOHCoreColor", c => c.String());
            AddColumn("dbo.InCImps", "OTDRDistance", c => c.Double(nullable: false));
            AddColumn("dbo.InCImps", "SpanLoss", c => c.Double(nullable: false));
            AddColumn("dbo.OverHeadImps", "ConfigDetails", c => c.String());
            AddColumn("dbo.OverHeadImps", "MUXSwithRouterInfo", c => c.String());
            AddColumn("dbo.OverHeadImps", "DeviceDetails", c => c.String());
            AddColumn("dbo.OverHeadImps", "CommissionedBy", c => c.String());
            DropColumn("dbo.InCImps", "ConfigDetails");
            DropColumn("dbo.InCImps", "MUXSwithRouterInfo");
            DropColumn("dbo.InCImps", "DeviceDetails");
            DropColumn("dbo.InCImps", "CommissionedBy");
            DropColumn("dbo.OverHeadImps", "FromSiteCableId");
            DropColumn("dbo.OverHeadImps", "FromSiteOHCoreColor");
            DropColumn("dbo.OverHeadImps", "ToSiteCableId");
            DropColumn("dbo.OverHeadImps", "ToSiteOHCoreColor");
            DropColumn("dbo.OverHeadImps", "OTDRDistance");
            DropColumn("dbo.OverHeadImps", "SpanLoss");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OverHeadImps", "SpanLoss", c => c.Double(nullable: false));
            AddColumn("dbo.OverHeadImps", "OTDRDistance", c => c.Double(nullable: false));
            AddColumn("dbo.OverHeadImps", "ToSiteOHCoreColor", c => c.String());
            AddColumn("dbo.OverHeadImps", "ToSiteCableId", c => c.String());
            AddColumn("dbo.OverHeadImps", "FromSiteOHCoreColor", c => c.String());
            AddColumn("dbo.OverHeadImps", "FromSiteCableId", c => c.String());
            AddColumn("dbo.InCImps", "CommissionedBy", c => c.String());
            AddColumn("dbo.InCImps", "DeviceDetails", c => c.String());
            AddColumn("dbo.InCImps", "MUXSwithRouterInfo", c => c.String());
            AddColumn("dbo.InCImps", "ConfigDetails", c => c.String());
            DropColumn("dbo.OverHeadImps", "CommissionedBy");
            DropColumn("dbo.OverHeadImps", "DeviceDetails");
            DropColumn("dbo.OverHeadImps", "MUXSwithRouterInfo");
            DropColumn("dbo.OverHeadImps", "ConfigDetails");
            DropColumn("dbo.InCImps", "SpanLoss");
            DropColumn("dbo.InCImps", "OTDRDistance");
            DropColumn("dbo.InCImps", "ToSiteOHCoreColor");
            DropColumn("dbo.InCImps", "ToSiteCableId");
            DropColumn("dbo.InCImps", "FromSiteOHCoreColor");
            DropColumn("dbo.InCImps", "FromSiteCableId");
        }
    }
}
