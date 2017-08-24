namespace AssetDbContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBranch : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrganizationId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        BranchCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Branches", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Branches", new[] { "OrganizationId" });
            DropTable("dbo.Branches");
        }
    }
}
