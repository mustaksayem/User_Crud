namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Halls",
                c => new
                    {
                        HallId = c.String(nullable: false, maxLength: 128),
                        HallName = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        Aname = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HallId)
                .ForeignKey("dbo.Admins", t => t.Aname)
                .Index(t => t.Aname);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Halls", "Aname", "dbo.Admins");
            DropIndex("dbo.Halls", new[] { "Aname" });
            DropTable("dbo.Halls");
        }
    }
}
