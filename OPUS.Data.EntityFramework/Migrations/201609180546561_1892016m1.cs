namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssignedSLAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SLAId = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        Status = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SLARuleSets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InitiatorDepartment = c.String(),
                        ResponsibleDepartment = c.String(),
                        SLAKey = c.String(),
                        SLAValueInHours = c.String(),
                        SLAKeyDescription = c.String(),
                        ProcessName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SLARuleSets");
            DropTable("dbo.AssignedSLAs");
        }
    }
}
