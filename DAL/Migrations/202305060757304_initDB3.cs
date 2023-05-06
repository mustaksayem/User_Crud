namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TKey = c.String(nullable: false, maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(),
                        Aname = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.Aname, cascadeDelete: true)
                .Index(t => t.Aname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminTokens", "Aname", "dbo.Admins");
            DropIndex("dbo.AdminTokens", new[] { "Aname" });
            DropTable("dbo.AdminTokens");
        }
    }
}
