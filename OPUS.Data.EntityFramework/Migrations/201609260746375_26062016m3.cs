namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _26062016m3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkOrderId = c.Int(nullable: false),
                        FromCableId = c.String(),
                        ToCableId = c.String(),
                        FromCoreColor = c.String(),
                        ToCoreColor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.WorkOrders", "Remarks", c => c.String());
            AddColumn("dbo.WorkOrders", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.WorkOrders", "FromCableId");
            DropColumn("dbo.WorkOrders", "ToCableId");
            DropColumn("dbo.WorkOrders", "FromCoreColor");
            DropColumn("dbo.WorkOrders", "ToCoreColor");
            DropColumn("dbo.WorkOrders", "ConfirmationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkOrders", "ConfirmationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.WorkOrders", "ToCoreColor", c => c.String());
            AddColumn("dbo.WorkOrders", "FromCoreColor", c => c.String());
            AddColumn("dbo.WorkOrders", "ToCableId", c => c.String());
            AddColumn("dbo.WorkOrders", "FromCableId", c => c.String());
            DropColumn("dbo.WorkOrders", "Date");
            DropColumn("dbo.WorkOrders", "Remarks");
            DropTable("dbo.WorkOrderDetails");
        }
    }
}
