namespace AssetDbContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAssetGroup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssetTypeId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        GroupCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssetTypes", t => t.AssetTypeId, cascadeDelete: true)
                .Index(t => t.AssetTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssetGroups", "AssetTypeId", "dbo.AssetTypes");
            DropIndex("dbo.AssetGroups", new[] { "AssetTypeId" });
            DropTable("dbo.AssetGroups");
        }
    }
}
