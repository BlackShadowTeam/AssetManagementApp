namespace AssetDbContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAssetManufacturer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetManufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetGroupId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        GroupCode = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetGroups", t => t.AssetGroupId, cascadeDelete: true)
                .Index(t => t.AssetGroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetManufacturers", "AssetGroupId", "dbo.AssetGroups");
            DropIndex("dbo.AssetManufacturers", new[] { "AssetGroupId" });
            DropTable("dbo.AssetManufacturers");
        }
    }
}
