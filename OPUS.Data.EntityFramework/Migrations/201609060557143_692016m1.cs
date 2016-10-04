namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _692016m1 : DbMigration
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
