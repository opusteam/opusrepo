namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26062016m6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CancelReasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(),
                        Published = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CancelReasons");
        }
    }
}
