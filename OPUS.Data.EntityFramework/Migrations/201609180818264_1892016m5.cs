namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "SLAIdOfFeasibilityCurrentState", c => c.Int(nullable: false));
            DropColumn("dbo.Feasibilities", "CurrentStateSLAId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "CurrentStateSLAId", c => c.Int(nullable: false));
            DropColumn("dbo.Feasibilities", "SLAIdOfFeasibilityCurrentState");
        }
    }
}
