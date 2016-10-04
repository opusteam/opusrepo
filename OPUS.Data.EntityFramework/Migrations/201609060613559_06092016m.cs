namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06092016m : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "IsPossibleWithSelectedConnectionType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Feasibilities", "IsPossibleWithSelectedConnectionType");
        }
    }
}
