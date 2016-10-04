namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _308m2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "ControllerName", c => c.String());
            AddColumn("dbo.Menus", "ActionName", c => c.String());
            AddColumn("dbo.Menus", "AreaName", c => c.String());
            DropColumn("dbo.Menus", "DepartmentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "DepartmentName", c => c.String());
            DropColumn("dbo.Menus", "AreaName");
            DropColumn("dbo.Menus", "ActionName");
            DropColumn("dbo.Menus", "ControllerName");
        }
    }
}
