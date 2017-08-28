namespace AssetDatabaseContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAssetLocation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        BranchCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .Index(t => t.OrganizationId)
                .Index(t => t.BranchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetLocations", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.AssetLocations", "BranchId", "dbo.Branches");
            DropIndex("dbo.AssetLocations", new[] { "BranchId" });
            DropIndex("dbo.AssetLocations", new[] { "OrganizationId" });
            DropTable("dbo.AssetLocations");
        }
    }
}
