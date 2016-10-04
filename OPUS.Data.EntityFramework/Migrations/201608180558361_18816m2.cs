namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18816m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(),
                        BusinessType = c.String(),
                        RegDate = c.DateTime(nullable: false),
                        CEOName = c.String(),
                        CEOPhone = c.String(),
                        CEOEmail = c.String(),
                        CTOName = c.String(),
                        CTOPhone = c.String(),
                        CTOEmail = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        OfficeAddress = c.String(),
                        Phone = c.String(nullable: false),
                        Fax = c.String(),
                        Email = c.String(nullable: false),
                        ComEmail = c.String(),
                        WebSite = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        PostalCode = c.String(),
                        BillingDepartment = c.String(),
                        VRN = c.String(),
                        Note = c.String(),
                        KamId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
