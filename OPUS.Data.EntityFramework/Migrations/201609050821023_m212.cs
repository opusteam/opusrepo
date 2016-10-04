namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m212 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProcessRemarks", "FeasibilityId", c => c.Int(nullable: false));
            AddColumn("dbo.ProcessRemarks", "Remarksfor", c => c.String());
            AddColumn("dbo.ProcessRemarks", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProcessRemarks", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProcessRemarks", "ModifiedDate");
            DropColumn("dbo.ProcessRemarks", "CreateDate");
            DropColumn("dbo.ProcessRemarks", "Remarksfor");
            DropColumn("dbo.ProcessRemarks", "FeasibilityId");
        }
    }
}
