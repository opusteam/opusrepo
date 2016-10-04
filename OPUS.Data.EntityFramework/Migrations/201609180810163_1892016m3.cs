namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "CurrentStateSLAId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feasibilities", "CurrentStateSLAId");
        }
    }
}
