namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _28092016m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "CancelReason", c => c.String());
            DropColumn("dbo.Feasibilities", "CancelRemarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "CancelRemarks", c => c.String());
            DropColumn("dbo.Feasibilities", "CancelReason");
        }
    }
}
