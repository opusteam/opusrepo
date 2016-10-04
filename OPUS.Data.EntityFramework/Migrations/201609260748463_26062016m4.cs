namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26062016m4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Feasibilities", "KAMWorkOrderRemarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "KAMWorkOrderRemarks", c => c.String());
        }
    }
}
