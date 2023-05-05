namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Aname = c.String(nullable: false, maxLength: 128),
                        AdminName = c.String(nullable: false, maxLength: 30),
                        AdminPassword = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Aname);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
