namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _19816m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "BusinessTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Clients", "VatNo", c => c.String());
            AddColumn("dbo.Clients", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Clients", "BusinessType");
            DropColumn("dbo.Clients", "CEOName");
            DropColumn("dbo.Clients", "CEOPhone");
            DropColumn("dbo.Clients", "CEOEmail");
            DropColumn("dbo.Clients", "CTOName");
            DropColumn("dbo.Clients", "CTOPhone");
            DropColumn("dbo.Clients", "CTOEmail");
            DropColumn("dbo.Clients", "ContactName");
            DropColumn("dbo.Clients", "ContactTitle");
            DropColumn("dbo.Clients", "ComEmail");
            DropColumn("dbo.Clients", "VRN");
            DropColumn("dbo.Clients", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Clients", "VRN", c => c.String());
            AddColumn("dbo.Clients", "ComEmail", c => c.String());
            AddColumn("dbo.Clients", "ContactTitle", c => c.String());
            AddColumn("dbo.Clients", "ContactName", c => c.String());
            AddColumn("dbo.Clients", "CTOEmail", c => c.String());
            AddColumn("dbo.Clients", "CTOPhone", c => c.String());
            AddColumn("dbo.Clients", "CTOName", c => c.String());
            AddColumn("dbo.Clients", "CEOEmail", c => c.String());
            AddColumn("dbo.Clients", "CEOPhone", c => c.String());
            AddColumn("dbo.Clients", "CEOName", c => c.String());
            AddColumn("dbo.Clients", "BusinessType", c => c.String());
            DropColumn("dbo.Clients", "ModifiedDate");
            DropColumn("dbo.Clients", "VatNo");
            DropColumn("dbo.Clients", "BusinessTypeId");
        }
    }
}
