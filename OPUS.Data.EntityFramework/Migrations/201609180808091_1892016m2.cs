namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AssignedSLAs", "SLARuleId", c => c.Int(nullable: false));
            AddColumn("dbo.AssignedSLAs", "EventId", c => c.Int(nullable: false));
            AddColumn("dbo.AssignedSLAs", "EventType", c => c.String());
            DropColumn("dbo.AssignedSLAs", "SLAId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssignedSLAs", "SLAId", c => c.Int(nullable: false));
            DropColumn("dbo.AssignedSLAs", "EventType");
            DropColumn("dbo.AssignedSLAs", "EventId");
            DropColumn("dbo.AssignedSLAs", "SLARuleId");
        }
    }
}
