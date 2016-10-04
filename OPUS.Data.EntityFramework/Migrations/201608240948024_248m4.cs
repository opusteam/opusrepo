namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _248m4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 160),
                        Designation = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Fax = c.String(),
                        Email = c.String(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactDetails", "ClientId", "dbo.Clients");
            DropIndex("dbo.ContactDetails", new[] { "ClientId" });
            DropTable("dbo.ContactDetails");
        }
    }
}
