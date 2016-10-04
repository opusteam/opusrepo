namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _192016m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProcessRemarks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Remarks = c.String(),
                        Remarksby = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Feasibilities", "Status", c => c.String());
            DropColumn("dbo.Feasibilities", "Remarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "Remarks", c => c.String());
            DropColumn("dbo.Feasibilities", "Status");
            DropTable("dbo.ProcessRemarks");
        }
    }
}
