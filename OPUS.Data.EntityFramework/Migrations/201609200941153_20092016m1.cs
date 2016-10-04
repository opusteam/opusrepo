namespace OPUS.Data.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20092016m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Feasibilities", "LastMileServiceTypeOfLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLocationA", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileServiceTypeOfLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLocationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType", c => c.String());
            DropColumn("dbo.Feasibilities", "LastMileServiceTypeOfLoacationA");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationABySelectedServiceType");
            DropColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLoacationA");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationAForSelectedImplementationType");
            DropColumn("dbo.Feasibilities", "LastMileServiceTypeOfLoacationB");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationBBySelectedServiceType");
            DropColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLoacationB");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationBForSelectedImplementationType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationBForSelectedImplementationType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLoacationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationBBySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileServiceTypeOfLoacationB", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLoacationAForSelectedImplementationType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLoacationA", c => c.String());
            AddColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLoacationABySelectedServiceType", c => c.String());
            AddColumn("dbo.Feasibilities", "LastMileServiceTypeOfLoacationA", c => c.String());
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLocationBForSelectedImplementationType");
            DropColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLocationB");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLocationBBySelectedServiceType");
            DropColumn("dbo.Feasibilities", "LastMileServiceTypeOfLocationB");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileImplementationTypeOfLocationAForSelectedImplementationType");
            DropColumn("dbo.Feasibilities", "LastMileImplementationTypeOfLocationA");
            DropColumn("dbo.Feasibilities", "IsPossibleLastMileServiceTypeOfLocationABySelectedServiceType");
            DropColumn("dbo.Feasibilities", "LastMileServiceTypeOfLocationA");
        }
    }
}
