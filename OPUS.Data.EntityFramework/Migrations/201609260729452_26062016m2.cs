namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26062016m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeasibilityId = c.Int(nullable: false),
                        FromCableId = c.String(),
                        ToCableId = c.String(),
                        FromCoreColor = c.String(),
                        ToCoreColor = c.String(),
                        ConfirmationDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkOrders");
        }
    }
}
