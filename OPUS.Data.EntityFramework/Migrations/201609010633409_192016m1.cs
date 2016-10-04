namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _192016m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HolidaySettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeeklyHoliday = c.String(),
                        HalfWeeklyHoliDay = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HolidayTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfficeHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OfficeWorkingDayTypeId = c.Int(nullable: false),
                        StartAt = c.String(nullable: false),
                        EndAt = c.String(nullable: false),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfficeWorkingDayTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OfficeWorkingDayTypes");
            DropTable("dbo.OfficeHours");
            DropTable("dbo.HolidayTypes");
            DropTable("dbo.HolidaySettings");
        }
    }
}
