namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _27092016m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "SLAtype", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feasibilities", "SLAtype");
        }
    }
}
