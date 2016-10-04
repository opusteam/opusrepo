namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1892016m4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "ClientVLANID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feasibilities", "ClientVLANID");
        }
    }
}
