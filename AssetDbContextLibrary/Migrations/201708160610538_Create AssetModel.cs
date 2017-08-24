namespace AssetDbContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAssetModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetGroupId = c.Int(nullable: false),
                        AssetManufacturerId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        GroupCode = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetGroups", t => t.AssetGroupId, cascadeDelete: true)
                .ForeignKey("dbo.AssetManufacturers", t => t.AssetManufacturerId, cascadeDelete: false)
                .Index(t => t.AssetGroupId)
                .Index(t => t.AssetManufacturerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetModels", "AssetManufacturerId", "dbo.AssetManufacturers");
            DropForeignKey("dbo.AssetModels", "AssetGroupId", "dbo.AssetGroups");
            DropIndex("dbo.AssetModels", new[] { "AssetManufacturerId" });
            DropIndex("dbo.AssetModels", new[] { "AssetGroupId" });
            DropTable("dbo.AssetModels");
        }
    }
}
