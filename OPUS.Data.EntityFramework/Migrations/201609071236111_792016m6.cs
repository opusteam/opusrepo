namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _792016m6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "KAMRemarks", c => c.String());
            AddColumn("dbo.Feasibilities", "KAMWorkOrderRemarks", c => c.String());
            AddColumn("dbo.Feasibilities", "CancelRemarks", c => c.String());
            AddColumn("dbo.Feasibilities", "PlanningRemarks", c => c.String());
            DropColumn("dbo.Feasibilities", "Remarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "Remarks", c => c.String());
            DropColumn("dbo.Feasibilities", "PlanningRemarks");
            DropColumn("dbo.Feasibilities", "CancelRemarks");
            DropColumn("dbo.Feasibilities", "KAMWorkOrderRemarks");
            DropColumn("dbo.Feasibilities", "KAMRemarks");
        }
    }
}
