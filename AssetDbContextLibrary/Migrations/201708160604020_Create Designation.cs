namespace AssetDbContextLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDesignation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Designations", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Designations", new[] { "DepartmentId" });
            DropTable("dbo.Designations");
        }
    }
}
