namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _18816m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Email", c => c.String(nullable: false));
            AddColumn("dbo.User", "ContactNo", c => c.String());
            AddColumn("dbo.User", "DepartmentName", c => c.String(nullable: false));
            AddColumn("dbo.User", "UserRole", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "UserRole");
            DropColumn("dbo.User", "DepartmentName");
            DropColumn("dbo.User", "ContactNo");
            DropColumn("dbo.User", "Email");
        }
    }
}
