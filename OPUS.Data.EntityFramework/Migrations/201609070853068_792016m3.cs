namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _792016m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "AddressOfSCLPOPLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "LatitudeOfSCLPOPLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "LongitudeOfSCLPOPLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "AddressOfSCLPOPLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "LatitudeOfSCLPOPLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "LongitudeOfSCLPOPLocationB", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feasibilities", "LongitudeOfSCLPOPLocationB");
            DropColumn("dbo.Feasibilities", "LatitudeOfSCLPOPLocationB");
            DropColumn("dbo.Feasibilities", "AddressOfSCLPOPLocationB");
            DropColumn("dbo.Feasibilities", "LongitudeOfSCLPOPLocationA");
            DropColumn("dbo.Feasibilities", "LatitudeOfSCLPOPLocationA");
            DropColumn("dbo.Feasibilities", "AddressOfSCLPOPLocationA");
        }
    }
}
