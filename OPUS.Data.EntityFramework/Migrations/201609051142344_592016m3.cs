namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _592016m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "IsExistingInterfaceForLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleWithExistingInterfaceForLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "IsExistingInterfaceForLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleWithExistingInterfaceForLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsServicePossibleWithSelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "IsRequiredCapacityDeliveryPossible", c => c.String());
            AddColumn("dbo.Feasibilities", "IsInterfaceTypePossible", c => c.String());
            AddColumn("dbo.Feasibilities", "IsInterfacecategoryPossible", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationABySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationAForSelectedImplementationType", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationBBySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationBForSelectedImplementationType", c => c.String());
            DropColumn("dbo.Feasibilities", "IsExistingInterface");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "IsExistingInterface", c => c.String());
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationBForSelectedImplementationType");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationBBySelectedServiceType");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationAForSelectedImplementationType");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationABySelectedServiceType");
            DropColumn("dbo.Feasibilities", "IsInterfacecategoryPossible");
            DropColumn("dbo.Feasibilities", "IsInterfaceTypePossible");
            DropColumn("dbo.Feasibilities", "IsRequiredCapacityDeliveryPossible");
            DropColumn("dbo.Feasibilities", "IsServicePossibleWithSelectedServiceType");
            DropColumn("dbo.Feasibilities", "IsPossibleWithExistingInterfaceForLocationB");
            DropColumn("dbo.Feasibilities", "IsExistingInterfaceForLocationB");
            DropColumn("dbo.Feasibilities", "IsPossibleWithExistingInterfaceForLocationA");
            DropColumn("dbo.Feasibilities", "IsExistingInterfaceForLocationA");
        }
    }
}
