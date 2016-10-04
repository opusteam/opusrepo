namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _308m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserMenuMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Feasibilities", "FeasiblityType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastModifiedBy", c => c.String());
            AddColumn("dbo.Feasibilities", "ModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Clients", "KamId", c => c.String());
            AlterColumn("dbo.Feasibilities", "KamId", c => c.String());
            AlterColumn("dbo.Feasibilities", "InterfaceType", c => c.String());
            AlterColumn("dbo.Feasibilities", "SubcategoryOfInterfaceCategory", c => c.String());
            DropColumn("dbo.Feasibilities", "FeasiblityTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "FeasiblityTypeId", c => c.String());
            AlterColumn("dbo.Feasibilities", "SubcategoryOfInterfaceCategory", c => c.Int(nullable: false));
            AlterColumn("dbo.Feasibilities", "InterfaceType", c => c.Int(nullable: false));
            AlterColumn("dbo.Feasibilities", "KamId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "KamId", c => c.Int(nullable: false));
            DropColumn("dbo.Feasibilities", "ModifiedDate");
            DropColumn("dbo.Feasibilities", "LastModifiedBy");
            DropColumn("dbo.Feasibilities", "FeasiblityType");
            DropTable("dbo.UserMenuMappings");
            DropTable("dbo.Menus");
        }
    }
}
