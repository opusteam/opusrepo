namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2992016m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CancelReasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(),
                        Published = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkOrderId = c.Int(nullable: false),
                        FromCableId = c.String(),
                        ToCableId = c.String(),
                        FromCoreColor = c.String(),
                        ToCoreColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeasibilityId = c.Int(nullable: false),
                        Remarks = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Feasibilities", "CancelReason", c => c.String());
            DropColumn("dbo.Feasibilities", "KAMWorkOrderRemarks");
            DropColumn("dbo.Feasibilities", "CancelRemarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "CancelRemarks", c => c.String());
            AddColumn("dbo.Feasibilities", "KAMWorkOrderRemarks", c => c.String());
            DropColumn("dbo.Feasibilities", "CancelReason");
            DropTable("dbo.WorkOrders");
            DropTable("dbo.WorkOrderDetails");
            DropTable("dbo.CancelReasons");
        }
    }
}
