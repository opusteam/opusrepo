namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _792016m5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProcessRemarks", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.ProcessRemarks", "ModifiedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProcessRemarks", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ProcessRemarks", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
