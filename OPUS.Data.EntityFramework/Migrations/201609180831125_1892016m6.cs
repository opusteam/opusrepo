namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Feasibilities", "SLAIdOfFeasibilityCurrentState");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "SLAIdOfFeasibilityCurrentState", c => c.Int(nullable: false));
        }
    }
}
