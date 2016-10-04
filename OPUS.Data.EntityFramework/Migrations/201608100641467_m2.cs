namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        holidaytype = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Holidays");
        }
    }
}
